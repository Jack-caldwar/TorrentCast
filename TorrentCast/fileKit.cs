using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace TorrentCast
{
    internal class fileKit
    {
        public static void archiveFiles(String path)
        {
            //todo pull destination from config
            String destination = "Archive";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            CheckDestinationExists(destinationDir);

            string fileName = Path.GetFileName(path);
            destination = Path.Combine(destinationDir, fileName);

            MoveOrReplace(path, destination);


        }

        private static void MoveOrReplace(string sourcePath, string destinationPath)
        {
            try
            {
                if (File.Exists(destinationPath))
                {
                    File.Delete(destinationPath);
                }
                else
                {
                    File.Move(sourcePath, destinationPath);
                }
            }
            catch (FileNotFoundException e)
            {
                //show error dialog
                MessageBox.Show("Error moving torrent \r\n Cannot locate :" + sourcePath + " \n \n Details :\n" + e.Message);
            }
        }

        public static void moveFilesToActive(string[] paths)
        {
            //todo pull destination from config
            String destination = "Active";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            CheckDestinationExists(destinationDir);

            foreach (var path in paths)
            {
                string fileName = Path.GetFileName(path) ;
                //if (fileName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
                //    continue;

                destination = Path.Combine(destinationDir, fileName);
                if (!fileName.Contains(".exe"))
                {
                    MoveOrReplace(path, destination);
                }
            }
        }
        public static void recoverFiles(string[] paths)
        {
            //todo pull destination from config
            String destination = "Active";
            String source = "Failed";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);
            string sourceDir = Path.Combine(localDirectory, source);

            CheckDestinationExists(destinationDir);

            foreach (var path in paths)
            {
                string fileName = Path.GetFileName(path) + ".torrent";
                destination = Path.Combine(destinationDir, fileName);
                source = Path.Combine(sourceDir, fileName);

                if (!fileName.Contains(".exe"))
                {

                    MoveOrReplace(source, destination);
                }
            }
        }
        public static string[] getArchivedTorrents()
        {
            //todo pull destination from config
            String destination = "Archive";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            string[] archivedTorrents = Array.Empty<string>();

            if (Directory.Exists(destinationDir)){
                archivedTorrents = Directory.GetFiles(destinationDir);
            }

            return archivedTorrents;


        }
        public static string[] getActiveTorrents()
        {
            //todo pull destination from config
            String destination = "Active";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            string[] activeTorrents = Array.Empty<string>();

            CheckDestinationExists(destinationDir);

            activeTorrents = Directory.GetFiles(destinationDir);

            activeTorrents = Array.FindAll(activeTorrents, file => file.EndsWith(".torrent", StringComparison.OrdinalIgnoreCase));

            return activeTorrents;
        }

        public static void CheckDestinationExists(string destination)
        {
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }
        }

        public static void DeleteArchived()
        {
            String destination = "Archive";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            string[] archivedTorrents = Array.Empty<string>();

            if (Directory.Exists(destinationDir))
            {
                archivedTorrents = Directory.GetFiles(destinationDir);
                foreach (var torrent in archivedTorrents)
                {
                    try
                    {
                        File.Delete(torrent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot Delete " + torrent + "\n" + ex.Message);
                    }
                }
            }

        }
        public static void DeleteArchived(List<String> paths)
        {
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string activeDirPath = Path.Combine(localDirectory, "Archive");
            foreach (var filename in paths)
            {
                try
                {
                    File.Delete(activeDirPath + "\\" + filename + ".torrent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot Delete " + filename + "\n" + ex.Message);

                }
            }

        }
       

        public static string[] getFailedTorrents()
        {
            //todo pull destination from config
            String destination = "Failed";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            string[] failedTorrents = Array.Empty<string>();

            if (Directory.Exists(destinationDir))
            {
                failedTorrents = Directory.GetFiles(destinationDir);
            }

            return failedTorrents;
        }

        internal static void DeleteFailed()
        {
            String destination = "Failed";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            string[] FailedTorrents = Array.Empty<string>();

            if (Directory.Exists(destinationDir))
            {
                FailedTorrents = Directory.GetFiles(destinationDir);
                foreach (var torrent in FailedTorrents)
                {
                    try
                    {
                        File.Delete(torrent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot Delete " + torrent + "\n" + ex.Message);
                    }
                }
            }
        }

        public static void DeleteFailed(List<String> paths)
        {
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string activeDirPath = Path.Combine(localDirectory, "Failed");
            foreach (var filename in paths)
            {
                try
                {
                    File.Delete(activeDirPath + "\\" + filename + ".torrent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot Delete " + filename + "\n" + ex.Message);

                }
            }

        }

        internal static void DeleteActive()
        {
            String destination = "Active";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            string[] ActiveTorrents = Array.Empty<string>();

            if (Directory.Exists(destinationDir))
            {
                ActiveTorrents = Directory.GetFiles(destinationDir);
                foreach (var torrent in ActiveTorrents)
                {
                    try
                    {
                        File.Delete(torrent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot Delete " + torrent + "\n" + ex.Message);

                    }
                }
            }
        }

        public static void MoveFailed(string path)
        {
            //todo pull destination from config
            String destination = "Failed";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            CheckDestinationExists(destinationDir);

            string fileName = Path.GetFileName(path);
            destination = Path.Combine(destinationDir, fileName);
            MoveOrReplace(path, destination);
        }

        public static void MoveFailed(List<string> paths)
        {
            //todo pull destination from config
            String destination = "Failed";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            string from = "Active";
            string fromDir = Path.Combine(localDirectory, from);
            

            CheckDestinationExists(destinationDir);

                foreach (var path in paths)
                {
                    string fileName = Path.GetFileName(path) + ".torrent";
                    destination = Path.Combine(destinationDir, fileName);
                    string source = Path.Combine(fromDir, fileName);
                MoveOrReplace(source, destination);
                }


        }

        internal static void DeleteActiveTorrent(List<String> paths)
        {


            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string activeDirPath = Path.Combine(localDirectory, "Active");
            foreach (var filename in paths)
            {
                try
                {
                    File.Delete(activeDirPath + "\\" + filename + ".torrent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot Delete " + filename + "\n" + ex.Message);

                }
            }
        }
    }
}
