using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace TorrentCast
{
    internal class FTPkit
    {
        public static int UploadViaFtp(ApplicationConfig config, string[] files)
        {
            int counter = 0;
            foreach (var file in files)
            {
                string filePath = file;
                string fileName = Path.GetFileName(file);
                string uploadUrl = $"ftp://{config.ftpHost}:{config.ftpPort}/{config.remotePath}/" + fileName;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uploadUrl);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(config.username, cryptoKit.DecryptString(config.password));
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
                    //check if 226 response                    
                    if (response.StatusCode == FtpStatusCode.ClosingData)
                    {
                        fileKit.archiveFiles(filePath);
                        counter++;
                    }
                    else
                    {
                        fileKit.MoveFailed(filePath);
                    }
                }
            }
            return counter;
        }

        public static int UploadViaFtpProgressUpdate(ApplicationConfig config, string[] files, IProgress<int> progress)
        {
            int counter = 0;
            foreach (var file in files)
            {

                string filePath = file;
                string fileName = Path.GetFileName(file);
                string uploadUrl = $"ftp://{config.ftpHost}:{config.ftpPort}/{config.remotePath}/" + fileName;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uploadUrl);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(config.username, cryptoKit.DecryptString(config.password));
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
                    //check if 226 response                    
                    if (response.StatusCode == FtpStatusCode.ClosingData)
                    {
                        fileKit.archiveFiles(filePath);
                        counter++;
                    }
                    else
                    {
                        fileKit.MoveFailed(filePath);
                    }
                }
                progress.Report(counter);
            }
            return counter;
        }

    }
}
