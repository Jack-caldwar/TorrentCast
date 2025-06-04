using System;
using System.IO;
using System.Windows.Forms;

namespace TorrentCast
{
    public partial class Archived : Form
    {
        public Archived()
        {
            InitializeComponent();
            loadArchivedTorrents();
        }

        private void loadArchivedTorrents()
        {
            String[] archivedTorrents = fileKit.getArchivedTorrents();

            dataGridView1.Rows.Clear();
            int counter = 0;

            foreach (var torrentPath in archivedTorrents)
            {
                counter++;
                String fileName = Path.GetFileName(torrentPath);
                String filePath = Path.GetDirectoryName(torrentPath);



                int rowIndex = dataGridView1.Rows.Add(counter, fileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                "This will delete all Archived Torrents?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                fileKit.DeleteArchived();
            }
            else
            {
                // Cancel deletion
                MessageBox.Show("Deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadArchivedTorrents();
        }

        private void Archived_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadArchivedTorrents();
        }
    }
}
