using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.IO.Pipes;
using System.Windows.Input;
using System.Security.Cryptography;
using System.Diagnostics;

namespace TorrentCast
{
    public class Program
    {
        static ApplicationConfig config = new ApplicationConfig();
        private static bool firstInstance;
        private static Mutex appMutex;

        [STAThread]
        static void Main()
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "launch.log");

            try
            {
                string[] startupArgs = Environment.GetCommandLineArgs();

                File.AppendAllText(
                    logPath,
                    $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] " +
                    $"ArgCount={startupArgs.Length} " +
                    $"Args={string.Join(" | ", startupArgs)}" +
                    Environment.NewLine
                );
            }
            catch
            {
                // don't let logging break app startup
            }

            appMutex = new Mutex(true, "TorrentCastMutex", out firstInstance);
            File.AppendAllText(logPath, "mutex :" + firstInstance + Environment.NewLine);
            if (!firstInstance)
            {
                File.AppendAllText( logPath, "duplicate entity found- switching to passover mode." +    Environment.NewLine);

                using (var client = new NamedPipeClientStream(".", "TorrentCastPipe", PipeDirection.Out))
                {
                    client.Connect();
                    using (var writer = new StreamWriter(client))
                    {
                        foreach (var arg in Environment.GetCommandLineArgs()) {

                            if (! arg.EndsWith("exe")) {
                                File.AppendAllText(logPath, "sending arg :" + arg  + Environment.NewLine);
                                writer.WriteLine(arg);
                                // skip the executable passed as first param
                            }
                        }
                    }
                }

                return; // closing duplicate instance
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                File.AppendAllText(logPath, "First launch" + Environment.NewLine);
                Form1 ui = new Form1(config);
                var listenerThread = new Thread(() =>
                {
                    while (true)
                    {
                        var server = new NamedPipeServerStream("TorrentCastPipe", PipeDirection.In);
                        server.WaitForConnection();
                        using (var reader = new StreamReader(server))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                String[] path = { line };
                                File.AppendAllText(logPath, "recieving arg : " + line + Environment.NewLine);
                                fileKit.moveFilesToActive(path);
                                ui.immediateDownload(path);
                            }
                        }
                    }
                });
                listenerThread.IsBackground = true;
                listenerThread.Start();


                try
                {


                    //get file paths
                    String[] paths = GetTorrentPaths();

                    //get config
                    
                    config.LoadConfig();

                    //DebugOutputConfig();

                    // if no file paths are passed, show the UI
                    
                    if (paths.Length == 1)
                    {
                        Application.Run(ui);                        
                        return;
                    }
                    else if (paths.Length == 2)
                    {
                        //move file to active folder and load ui
                        //MessageBox.Show("TorrentCast is already running. Adding torrent to active list." + paths[1], "TorrentCast");
                        fileKit.moveFilesToActive(paths);
                        Application.Run(ui);

                        return;
                    }
                }
                catch (Exception ex)
                {
                    File.WriteAllText("error.log", ex.ToString());
                    MessageBox.Show(ex.ToString(), "TorrentCast Error");
                }
            }

        }

        private static String[] GetTorrentPaths()
        {
            string[] args = Environment.GetCommandLineArgs();
            string[] filePaths = new string[args.Length];

            if (args.Length > 1)
            {
                int i = 0;
                foreach (var entry in args)
                {
                    filePaths[i] = entry;
                    i++;
                }
            }

            return filePaths;
        }
    }
}