using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace TorrentCast
{
    
    public partial class Form1 : Form
    {
        int counter = 0;
        string selectHeader = "Select";

        private ApplicationConfig config;
        public Form1(ApplicationConfig config)
        {

            InitializeComponent();

            this.config = config;
            setupWatcher();
            populateFileList();


        }
        private FileSystemWatcher watcher;

        private void setupWatcher()
        {
            watcher = new FileSystemWatcher();

            String destination = "Active";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            fileKit.CheckDestinationExists(destinationDir);

            watcher.Path = destinationDir;
            watcher.IncludeSubdirectories = false;
            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

            watcher.Created += OnFileChanged;
            watcher.Deleted += OnFileChanged;
            watcher.Renamed += OnFileRenamed;

            watcher.EnableRaisingEvents = true;
        }
        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.ChangeType}: {e.FullPath}");
            refreshUI();
        }

        private void OnFileRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File Renamed: {e.OldFullPath} → {e.FullPath}");
            refreshUI();
        }

        private void refreshUI()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(refreshUI));
                return;
            }

            activeGrid.Rows.Clear();

            populateFileList();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // shows the config form
            ConfigForm cfgForm = new ConfigForm();
            cfgForm.Show();
            cfgForm.Closed += (s, args) =>
            {
                config.LoadConfig();
            };

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void populateFileList()
        {

            activeGrid.Rows.Clear();
            int counter = 0;
            string[] activeFileList = fileKit.getActiveTorrents();

            foreach (string file in activeFileList)
            {
                counter++;
                //remove extension
                String fileName = Path.GetFileNameWithoutExtension(file);
                //String fileName = Path.GetFileName(file);
                //String filePath = Path.GetDirectoryName(file);



                int rowIndex = activeGrid.Rows.Add(counter, fileName);

                
            }
            torrentCount.Text = counter.ToString();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // process the active file list
            string[] activeFileList = fileKit.getActiveTorrents();

            int progressBarMax = activeFileList.Length;
            progressBar1.Maximum = progressBarMax;
            progressBar1.Value = 0;

            var progress = new Progress<int>(value =>
            {
                progressBar1.Value = value; // This runs on the UI thread
            });

            Task<int> task = Task.Run(() =>
            {
                return FTPkit.UploadViaFtpProgressUpdate(config, activeFileList, progress);

            });

            int uploaded = await task;
            MessageBox.Show(uploaded + " torrents successfully uploaded.", "TorrentCast Upload");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Archived archivedForm = new Archived();
            archivedForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FailedUi failedForm = new FailedUi();
            failedForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MakeActiveButton_Click(object sender, EventArgs e)
        {
//get Active DGV
            DataGridView active = activeGrid;
            DataGridView download = DownloadGrid;
//loop over each row
            foreach (DataGridViewRow row in active.Rows)
            {
                if (!row.IsNewRow)
                {
//get selected rows
                    bool selected = row.Cells[selectHeader].Value as bool? ??  false;
            
                    if (selected)
                    {
                        row.Cells[selectHeader].Value = false;
//move to Download DGV
                        active.Rows.Remove(row);
                        download.Rows.Add(row);
                        
                    }
                }
            }
        }
    }
}
