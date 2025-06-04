using System;
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
            File.Move(path, destination);


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
                string fileName = Path.GetFileName(path);
                destination = Path.Combine(destinationDir, fileName);
                if (!fileName.Contains(".exe"))
                {
                    File.Move(path, destination);
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


        private static void CheckDestinationExists(string destination)
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

        public static void MoveFailed(string path)
        {
            //todo pull destination from config
            String destination = "Failed";
            string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string destinationDir = Path.Combine(localDirectory, destination);

            CheckDestinationExists(destinationDir);

            string fileName = Path.GetFileName(path);
            destination = Path.Combine(destinationDir, fileName);
            File.Move(path, destination);
        }
    }
}
