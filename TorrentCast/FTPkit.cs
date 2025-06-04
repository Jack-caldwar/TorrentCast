using System.IO;
using System.Net;
using System.Windows.Forms;

namespace TorrentCast
{
    internal class FTPkit
    {
        public static void UploadViaFtp(ApplicationConfig config, string[] files)
        {

            foreach (var file in files)
            {
                string filePath = file;
                string fileName = Path.GetFileName(file);
                string uploadUrl = $"ftp://{config.ftpHost}:{config.ftpPort}/{config.remotePath}/" + fileName;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uploadUrl);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(config.username, config.password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;
                byte[] fileContents = File.ReadAllBytes(filePath);
                request.ContentLength = fileContents.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    //MessageBox.Show($"FTP Upload complete: {response.StatusDescription}");
                    
                    if (response.StatusCode == FtpStatusCode.CommandOK)
                    {
                        fileKit.archiveFiles(filePath);
                    }
                    else
                    {
                        fileKit.MoveFailed(filePath);
                    }
                }
            }

        }

    }
}
