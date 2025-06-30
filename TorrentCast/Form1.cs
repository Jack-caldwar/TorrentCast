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

        private ApplicationConfig config;
        public Form1(ApplicationConfig config)
        {

            InitializeComponent();

            this.config = config;
            setupWatcher();
            populateFileList();

            dataGridView1.CellMouseClick += removeHandler;

        }
        private FileSystemWatcher watcher;

        private void setupWatcher()
        {
            watcher = new FileSystemWatcher();

            String destination = "Active";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

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

            dataGridView1.Rows.Clear();

            populateFileList();
        }

        private void removeHandler(object sender, DataGridViewCellMouseEventArgs e)
        {


            var column = dataGridView1.Columns[e.ColumnIndex];
            if (column.Name == "actions")
            {

                string fileName = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();

                //todo pull from config later on

                String destination = "Active";
                string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string activeDirectory = Path.Combine(localDirectory, destination);
                string targetFile = activeDirectory + "\\" + fileName;
                fileKit.archiveFiles(targetFile);
                //dataGridView1.Rows.Clear();


            }
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

            dataGridView1.Rows.Clear();
            int counter = 0;
            string[] activeFileList = fileKit.getActiveTorrents();

            foreach (string file in activeFileList)
            {
                counter++;
                //remove extension
                String fileName = Path.GetFileNameWithoutExtension(file);
                //String fileName = Path.GetFileName(file);
                //String filePath = Path.GetDirectoryName(file);



                int rowIndex = dataGridView1.Rows.Add(counter, fileName);

                var buttonCell = new DataGridViewButtonCell
                {
                    Value = "--Remove--"
                };

                dataGridView1.Rows[rowIndex].Cells["actions"] = buttonCell;

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
    }
}
