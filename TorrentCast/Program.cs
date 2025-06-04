using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.IO.Pipes;

namespace TorrentCast
{
    public class Program
    {
        static ApplicationConfig config = new ApplicationConfig();
        private static bool firstInstance;

        [STAThread]
        static void Main()
        {
            var mutex = new Mutex(true, "TorrentCastMutex", out firstInstance);


            if (!firstInstance)
            {
                using (var client = new NamedPipeClientStream(".", "TorrentCastPipe", PipeDirection.Out))
                {
                    client.Connect();
                    using (var writer = new StreamWriter(client))
                    {
                        foreach (var arg in Environment.GetCommandLineArgs())
                            writer.WriteLine(arg);
                    }
                }

                return; // closing duplicate instance
            }
            else
            {
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
                                fileKit.moveFilesToActive(path);
                            }
                        }
                    }
                });
                listenerThread.IsBackground = true;
                listenerThread.Start();
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    //get file paths
                    String[] paths = GetTorrentPaths();

                    //get config
                    
                    config.LoadConfig();

                    //DebugOutputConfig();

                    // if no file paths are passed, show the UI
                    Form1 ui = new Form1(config);
                    if (paths.Length == 1)
                    {
                        Application.Run(ui);
                        return;
                    }
                    else if (paths.Length == 2)
                    {
                        //move file to active folder and load ui
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


            void DebugOutputConfig()
            {
                String readOutConfig = ".username :" + config.username + " password :" + config.password + " server :" +
                                       config.ftpHost + " port :" + config.ftpPort + " activeFolder :" +
                                       config.activeFolder + " archiveFolder :" + config.archiveFolder +
                                       " torrentFolder :" + config.remotePath;
                MessageBox.Show(readOutConfig);
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