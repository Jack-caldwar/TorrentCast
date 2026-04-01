using BencodeNET.Objects;
using BencodeNET.Parsing;
using BencodeNET.Torrents;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace TorrentCast
{

    public partial class Form1 : Form
    {
        int counter = 0;
        string selectHeader = "Select";
        private DataGridView active;
        private DataGridView download;
        private ApplicationConfig config;

        public Form1(ApplicationConfig config)
        {

            InitializeComponent();
            active = activeGrid;
            download = DownloadGrid;
            this.config = config;
            setupWatcher();
            populateServerList();
            populateFileList();
            populateArchivedList();
            populateFailedList();

            config.LoadConfig();
            displayConfig(config);
        }

        private void populateFailedList()
        {
            failedGrid.Rows.Clear();
            string[] strings = fileKit.getFailedTorrents();
            int counter = 1;
            foreach (string file in strings)
            {

                string fileName = Path.GetFileNameWithoutExtension(file);
                failedGrid.Rows.Add(counter, fileName);
                counter++;
            }
        }

        private void populateArchivedList()
        {
            archivedGrid.Rows.Clear();
            string[] strings = fileKit.getArchivedTorrents();
            int counter = 1;
            foreach (string file in strings)
            {

                string fileName = Path.GetFileNameWithoutExtension(file);
                archivedGrid.Rows.Add(counter, fileName);
                counter++;
            }
        }

        private void populateServerList()
        {
            string jsonString = null;

            string basePath = AppContext.BaseDirectory;
            string configPath = Path.Combine(basePath, "AnnounceServers.json");

            if (!File.Exists(configPath))
            {
                Dictionary<string, string> data = new Dictionary<string, string> { };

                String stringCFG = JsonConvert.SerializeObject(data, Formatting.Indented);

                FileStream fs = File.Create(configPath);
                fs.Write(System.Text.Encoding.UTF8.GetBytes(stringCFG), 0, System.Text.Encoding.UTF8.GetBytes(stringCFG).Length);
                fs.Close();
            }
            else
            {
                try
                {
                    jsonString = File.ReadAllText(configPath);

                    Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);

                    foreach (var kvp in data)
                    {
                        string url = kvp.Key;
                        string name = kvp.Value;
                        serverGrid.Rows.Add(url, name);
                    }

                }
                catch (JsonException ex)
                {
                    Console.WriteLine("Error parsing Announce Server file: " + ex.Message);
                }
            }

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
            searchGrid.Rows.Clear();
            failedGrid.Rows.Clear();
            archivedGrid.Rows.Clear();

            populateFileList();
            populateArchivedList();
            populateFailedList();
        }


        private void populateFileList()
        {
            var parser = new BencodeParser();

            activeGrid.Rows.Clear();
            int counter = 0;
            string[] activeFileList = fileKit.getActiveTorrents();
            HashSet<string> allTags = new HashSet<string>();

            foreach (string file in activeFileList)
            {
                counter++;

                String fileName = Path.GetFileNameWithoutExtension(file);

                HashSet<string> tags = getTags(fileName);

                Torrent torrent = parser.Parse<Torrent>(file);

                IList<IList<string>> trackers = torrent.Trackers;

                tags = saveUpdateTrackers(torrent.Trackers, tags);

                activeGrid.Rows.Add(counter, fileName, string.Join(" ", tags), false);

                allTags.UnionWith(tags);
            }

            searchBox.Items.AddRange(allTags.ToArray());


        }

        //private void addTestValues(DataGridView grid)
        //{
        //    grid.Rows.Add(1, "fileName", "ss ss dd dd", false);
        //    grid.Rows.Add(2, "fileName", "ss ss dd dd", false);
        //    grid.Rows.Add(3, "fileName", "ss ss dd dd", false);
        //    grid.Rows.Add(4, "fileName", "ss ss dd dd", false);
        //    grid.Rows.Add(5, "fileName", "ss ss dd dd", false);
        //}

        private HashSet<string> saveUpdateTrackers(IList<IList<string>> trackers, HashSet<string> tags)
        {
            foreach (var tracker in trackers)
            {
                foreach (var url in tracker)
                {
                    Uri uri = new Uri(url);

                    tags.Add(addAnnounceServer(uri.Host));
                }
            }
            return tags;
        }

        private HashSet<string> getTags(string filename)
        {
            HashSet<string> tags = new HashSet<string>();
            MatchCollection tagMatches = Regex.Matches(filename, @"\[(.*?)\]");
            foreach (Match match in tagMatches)
            {
                string tag = match.Groups[1].Value;
                tags.Add(tag);
            }
            return tags;
        }

        private string addAnnounceServer(string announceUrl)
        {

            foreach (DataGridViewRow row in serverGrid.Rows)
            {
                string existingUrl = row.Cells[0].Value as string;

                //return existing tag if url already exists in grid
                if (existingUrl == announceUrl)
                {
                    String tag = row.Cells[1].Value as String;
                    return tag;
                }
            }

            serverGrid.Rows.Add(announceUrl, "?");
            return "?";
        }

        private void MakeActiveButton_Click(object sender, EventArgs e)
        {

            for (int i = activeGrid.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = activeGrid.Rows[i];

                if (!row.IsNewRow)
                {
                    bool selected = row.Cells[3].Value as bool? ?? false;

                    if (selected)
                    {
                        activeGrid.Rows.RemoveAt(i);
                        download.Rows.Add(row);
                    }
                }
            }
        }

        private void SelectAllDownloadsButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in download.Rows)
            {
                row.Cells["DownloadSelect"].Value = true;
            }

        }

        private void SelectAllActiveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in active.Rows)
            {
                row.Cells[selectHeader].Value = true;
            }
        }

        private void DeleteActiveButton_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Are you sure you want to delete the selected torrents?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Exclamation);
            if (result == MessageBoxResult.Yes)
            {
                List<String> paths = GetSelected(activeGrid, "Select");
                fileKit.DeleteActiveTorrent(paths);
                refreshUI();
            }

        }

        private async void StartDownloadButton_Click(object sender, EventArgs e)
        {
            //make a list of filenames from download pane
            List<String> filenames = new List<String>();

            GetSelected(download, "DownloadSelect").ForEach(name => filenames.Add(name));

            int progressBarMax = filenames.Count;
            progressBar2.Maximum = progressBarMax;
            progressBar2.Value = 0;

            var progress = new Progress<int>(value =>
            {
                progressBar2.Value = value; // This runs on the UI thread
            });

            Task<int> task = Task.Run(() =>
            {
                try
                {
                    return FTPkit.UploadViaFtpProgressUpdate(config, filenames.ToArray(), progress);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during upload: " + ex.Message, "Upload Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    fileKit.MoveFailed(filenames);
                    populateFailedList();
                    removeSelectedActive();
                    return 0;
                }


            });

            int uploaded = await task;
            MessageBox.Show(uploaded + " torrents successfully uploaded.", "TorrentCast Upload");
            removeSelectedActive();

        }

        private void RemoveDownloadButton_Click(object sender, EventArgs e)
        {
            removeSelectedActive();
            refreshUI();
        }

        private void removeSelectedActive()
        {
            int rowCount = download.Rows.Count;
            for (int i = rowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = download.Rows[i];
                bool selected = row.Cells["DownloadSelect"].Value as bool? ?? false;
                if (selected)
                {
                    download.Rows.Remove(row);
                }
            }
        }

        private void DeleteDownloadButton_Click(object sender, EventArgs e)
        {
            //get confirmation from user
            MessageBoxResult result = MessageBox.Show(
                "Are you sure you want to delete the selected torrents?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Exclamation);

            if (result == MessageBoxResult.Yes)
            {
                //gather list of names to delete.
                List<String> pathsToDelete = GetSelected(DownloadGrid, "DownloadSelect");
                //call deletion from active directory
                fileKit.DeleteActiveTorrent(pathsToDelete);
                //delete selected records from grid
                int rowCount = download.Rows.Count;
                for (int i = rowCount - 1; i >= 0; i--)
                {
                    DataGridViewRow row = download.Rows[i];
                    bool selected = row.Cells["DownloadSelect"].Value as bool? ?? false;
                    if (selected)
                    {
                        download.Rows.Remove(row);
                    }
                }
            }
            refreshUI();
        }

        private List<String> GetSelected(DataGridView grid, String selectCol)
        {
            List<String> result = new List<String>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                bool selected = row.Cells[selectCol].Value as bool? ?? false;
                if (selected)
                {
                    string filename = row.Cells[1].Value as string;
                    result.Add(filename);
                }
            }
            return result;
        }

        private void SaveServerNameButton_Click(object sender, EventArgs e)
        {

            string basePath = AppContext.BaseDirectory;
            string configPath = Path.Combine(basePath, "AnnounceServers.json");

            Dictionary<string, string> data = new Dictionary<string, string> { };

            foreach (DataGridViewRow row in serverGrid.Rows)
            {
                string url = row.Cells[0].Value as string;
                string name = row.Cells[1].Value as string;

                if (!string.IsNullOrEmpty(url) && !string.IsNullOrEmpty(name))
                {
                    data.Add(url, name);
                }
            }

            String stringCFG = JsonConvert.SerializeObject(data, Formatting.Indented);

            FileStream fs = File.Create(configPath);
            fs.Write(System.Text.Encoding.UTF8.GetBytes(stringCFG), 0, System.Text.Encoding.UTF8.GetBytes(stringCFG).Length);
            fs.Close();

            MessageBox.Show("Announce Server names saved successfully.", "TorrentCast Configuration");
        }

        private void deleteServer_Click(object sender, EventArgs e)
        {
            int deleted = 0;
            for (int i = serverGrid.RowCount - 1; i >= 0; i--)
            {

                DataGridViewRow row = serverGrid.Rows[i];
                bool selected = row.Cells["SelectServer"].Value as bool? ?? false;
                if (selected)
                {
                    serverGrid.Rows.Remove(row);
                    deleted++;
                }

            }

            if (deleted > 0)
            {
                MessageBox.Show("Click on SAVE to confirm", deleted + " announce servers deleted");
            }
        }

        private void SelectAllArchived_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in archivedGrid.Rows)
            {
                row.Cells["ArchiveSelectColumn"].Value = true;
            }
        }

        private void DeleteArchived_Click(object sender, EventArgs e)
        {
            List<String> paths = GetSelected(archivedGrid, "ArchiveSelectColumn");
            fileKit.DeleteArchived(paths);
            populateArchivedList();
        }

        private void SelectAllDeleted_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in failedGrid.Rows)
            {
                row.Cells["failedSelected"].Value = true;
            }
        }

        private void DeleteFailed_Click(object sender, EventArgs e)
        {
            List<String> paths = GetSelected(archivedGrid, "failedSelected");
            fileKit.DeleteFailed(paths);
            populateFailedList();
        }

        private void DownloadFailed_Click(object sender, EventArgs e)
        {
            List<String> paths = GetSelected(failedGrid, "failedSelected");
            fileKit.recoverFiles(paths.ToArray());
            populateFailedList();
            populateFileList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchGrid.Rows.Clear();
            searchTorrent();

        }

        private void searchTorrent()
        {
            //get search param
            string searchTerm = searchBox.Text.ToLower();
            //grab torrs from active and loop over
            foreach (DataGridViewRow row in activeGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    string fileName = row.Cells[1].Value as string;
                    string tags = row.Cells["serverTagColumn"].Value as string;
                    int id = (int)row.Cells[0].Value;
                    if
                        ((fileName != null && fileName.ToLower().Contains(searchTerm)) || (tags != null && tags.ToLower().Contains(searchTerm)))
                    {
                        searchGrid.Rows.Add(id, fileName, tags, false);

                    }
                }
            }
        }


        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            searchGrid.Rows.Clear();
            searchBox.Text = "";
        }

        private void SelectAllSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in searchGrid.Rows)
            {
                row.Cells["SearchSelect"].Value = true;
            }
        }

        private void DownloadSearchButton_Click(object sender, EventArgs e)
        {
            List<string> filenames = new List<string>();

            //loop over each row
            for (int i = searchGrid.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = searchGrid.Rows[i];

                if (!row.IsNewRow)
                {
                    //get selected rows
                    bool selected = row.Cells[3].Value as bool? ?? false;

                    if (selected)
                    {
                        //move to Download DGV
                        searchGrid.Rows.Remove(row);
                        download.Rows.Add(row);
                        filenames.Add((string)(row.Cells[1].Value));
                    }
                }
            }
            removeFromActive(filenames);
        }

        private void removeFromActive(List<string> filenames)
        {
            int removalCount = filenames.Count;
            int rowCount = activeGrid.Rows.Count;

            for (int i = rowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = activeGrid.Rows[i];
                string fileName = row.Cells[1].Value as string;
                if (filenames.Contains(fileName))
                {
                    activeGrid.Rows.Remove(row);
                    removalCount--;
                }

                if (removalCount == 0)
                {
                    break;
                }
            }


        }

        private void DownloadGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                var row = download.CurrentRow;
                if (row != null)
                {
                    bool currentValue = row.Cells["DownloadSelect"].Value as bool? ?? false;
                    row.Cells["DownloadSelect"].Value = !currentValue;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(usernameTextbox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextbox.Text) ||
                string.IsNullOrWhiteSpace(urlTextbox.Text) ||
                string.IsNullOrWhiteSpace(porttextbox.Text) ||
                string.IsNullOrWhiteSpace(remoteDirTextbox.Text)
                )
            {
                MessageBox.Show("You need to fill all fields!", "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
            else
            {
                ApplicationConfig config = new ApplicationConfig();
                config.username = usernameTextbox.Text;

                string password = cryptoKit.EncryptString(passwordTextbox.Text);
                config.password = password;

                //config.password = passwordTextbox.Text;
                config.ftpHost = urlTextbox.Text;
                config.ftpPort = porttextbox.Text;
                config.remotePath = remoteDirTextbox.Text;
                config.SaveConfig();
                MessageBox.Show("Configuration Updated!", "Saved", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void displayConfig(ApplicationConfig config)
        {
            // Display the configuration in the form controls
            usernameTextbox.Text = config.username;
            string password = cryptoKit.DecryptString(config.password);
            passwordTextbox.Text = password;
            urlTextbox.Text = config.ftpHost;
            porttextbox.Text = config.ftpPort;
            remoteDirTextbox.Text = config.remotePath;
            // mb.Text = cryptoKit.GetMotherboardSerial() ?? "Unknown Motherboard Serial";
        }

        private void OpenFoldersButton_Click(object sender, EventArgs e)
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Process.Start("explorer.exe", exeDirectory);
        }

        private void searchButtonHandler(object sender, KeyEventArgs e)
        {
            searchGrid.Rows.Clear();
            searchTorrent();
        }

        private void FailedTab_Click(object sender, EventArgs e)
        {

        }

        private void ActiveGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                var row = active.CurrentRow;
                if (row != null)
                {
                    bool currentValue = row.Cells["Select"].Value as bool? ?? false;
                    row.Cells["Select"].Value = !currentValue;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
    "Are you sure you want to delete the selected torrents?",
    "Confirm Delete",
    MessageBoxButton.YesNo,
    MessageBoxImage.Exclamation);
            if (result == MessageBoxResult.Yes)
            {
                List<String> paths = GetSelected(searchGrid, "SearchSelect");
                fileKit.DeleteActiveTorrent(paths);

                refreshUI();
            }
        }

        internal void immediateDownload(string[] path)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((Action)(() => immediateDownload(path)));
                return;
            }

            DownloadGrid.Rows.Add(
                DownloadGrid.Rows.Count + 1,
                Path.GetFileNameWithoutExtension(path[0]),
                string.Join(" ", getTags(Path.GetFileNameWithoutExtension(path[0]))),
                true
            );

            //remove from active grid
            foreach (DataGridViewRow row in activeGrid.Rows)
            {
                string fileName = row.Cells[1].Value as string;
                if (fileName == Path.GetFileNameWithoutExtension(path[0]))
                {
                    activeGrid.Rows.Remove(row);
                    break;
                }

            }
        }
    }
}
