using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using Button = System.Windows.Controls.Button;
using MessageBox = System.Windows.MessageBox;

namespace TorrentCast
{
    public partial class Form1 : Form
    {
        int counter = 0;

        private ApplicationConfig config;
        public Form1(ApplicationConfig config)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();

            this.config = config;
            //populateFileList(activeFileList);

            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(2) // Adjust to your needs
            };
            timer.Tick += (sender, e) =>
            {
                // check active folder for new files
                // if new files are found, add them to the list
                string[] newActiveFileList = getActiveFileList();

                int rowCount = dataGridView1.RowCount - 1;
                torrentCount.Text = rowCount.ToString();


                int pendingFiles = newActiveFileList.Length;


                if (pendingFiles != 0)
                {
                    if(pendingFiles != rowCount)
                    {
                        populateFileList(newActiveFileList);
                    }                    
                }
                
            };
            timer.Start();

           // dataGridView1.CellMouseClick += removeHandler;

        }

        private void removeHandler(object sender, DataGridViewCellMouseEventArgs e)
        {


            var column = dataGridView1.Columns[e.ColumnIndex];
            if (column.Name == "actions")
            {
                string filepath = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                string fileName = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                MessageBox.Show("removing "+filepath + "\\" + fileName);

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

        private static string[] getActiveFileList()
        {
            String activeFileFolder = "Active";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string activeFileFolderPath = Path.Combine(localDirectory, activeFileFolder);

            string[] activeFileList = Directory.GetFiles(activeFileFolderPath);
            return activeFileList;
        }

        private void populateFileList(string[] activeFileList)
        {
            dataGridView1.Rows.Clear();
            int counter = 0;

            foreach (string file in activeFileList)
            {
                counter++;
                String fileName = Path.GetFileName(file);
                String filePath = Path.GetDirectoryName(file);



                int rowIndex = dataGridView1.Rows.Add(counter, fileName);

                var buttonCell = new DataGridViewButtonCell
                {
                    Value = "Remove" 
                };

                dataGridView1.Rows[rowIndex].Cells["actions"] = buttonCell;

            }

        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn )
            {

                // implement sending logic
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn )
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // process the active file list
            string[] activeFileList = getActiveFileList();
            FTPkit.UploadViaFtp(config, activeFileList);

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
