using System;
using System.IO;
using System.Windows.Forms;

namespace TorrentCast
{
    public partial class FailedUi : Form
    {
        public FailedUi()
        {
            InitializeComponent();
            loadFailedTorrents();
        }

        private void loadFailedTorrents()
        {
            string[] failedTorrents = fileKit.getFailedTorrents();
            dataGridView1.Rows.Clear();
            int counter = 0;

            foreach (var torrentPath in failedTorrents)
            {
                counter++;
                String fileName = Path.GetFileName(torrentPath);
                String filePath = Path.GetDirectoryName(torrentPath);
                int rowIndex = dataGridView1.Rows.Add(counter, fileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //move torrents back to active.
            var result = MessageBox.Show("Are you sure you want to ReQueue all failed torrents?", "Confirm ReQueue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string[] failedTorrents = fileKit.getFailedTorrents();
                fileKit.moveFilesToActive(failedTorrents);
            }
            else
            {
                MessageBox.Show("ReQueue cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //load torrents from folder again
            loadFailedTorrents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete all failed torrents in folder
            var result = MessageBox.Show("Are you sure you want to delete all failed torrents?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                fileKit.DeleteFailed();
            }
            else
            {
                MessageBox.Show("Delete cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
