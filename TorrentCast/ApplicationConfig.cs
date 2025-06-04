
using System;
using System.IO;
using Newtonsoft.Json;


namespace TorrentCast
{
    public class ApplicationConfig
    {
         public string username { get; set; }
         public string password { get; set; }
         public string ftpHost { get; set; }
         public string ftpPort { get; set; }
         public string activeFolder { get; set; }
         public string archiveFolder { get; set; }
         public string remotePath { get; set; }



        public ApplicationConfig LoadConfig()
        {
            string jsonString = null;
            string basePath = AppContext.BaseDirectory;
            string configPath = Path.Combine(basePath, "config.json");
            //check if file exists
            if (!File.Exists(configPath))
            {
                //todo raise some kind of error.

                
            }
            else
            {
                jsonString = File.ReadAllText(configPath);
            }

            ApplicationConfig config = JsonConvert.DeserializeObject<ApplicationConfig>(jsonString);
            this.username = config.username;
            this.password = config.password;
            this.ftpHost = config.ftpHost;
            this.ftpPort = config.ftpPort;
            this.activeFolder = config.activeFolder;
            this.archiveFolder = config.archiveFolder;
            this.remotePath = config.remotePath;

            //read out the config file
            return config;
        }

        public void SaveConfig()
        {
            string config = JsonConvert.SerializeObject(this, Formatting.Indented);
            string basePath = AppContext.BaseDirectory;
            string configPath = Path.Combine(basePath, "config.json");
            //check if file exists
            File.WriteAllText(configPath, config);

        }




    }
    
}