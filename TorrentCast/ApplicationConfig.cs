
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
            ApplicationConfig config = new ApplicationConfig();

            string basePath = AppContext.BaseDirectory;
            string configPath = Path.Combine(basePath, "config.json");

            //check if file exists
            if (!File.Exists(configPath))
            {
                //generate blank cfg file.
                ApplicationConfig cfg = new ApplicationConfig
                {
                    username = "",
                    password = "",
                    ftpHost = "yourHost",
                    ftpPort = "21",
                    activeFolder = "active",
                    archiveFolder = "archive",
                    remotePath = "/your/path"
                };

                String stringCFG = JsonConvert.SerializeObject(cfg, Formatting.Indented);

                FileStream fs = File.Create(configPath);
                fs.Write(System.Text.Encoding.UTF8.GetBytes(stringCFG),0, System.Text.Encoding.UTF8.GetBytes(stringCFG).Length);
                fs.Close();
                jsonString = stringCFG; // Use the newly created config
            }
            else
            {
                try
                {
                    jsonString = File.ReadAllText(configPath);
                    config = JsonConvert.DeserializeObject<ApplicationConfig>(jsonString);

                    this.username = config.username;
                    this.password = config.password;
                    this.ftpHost = config.ftpHost;
                    this.ftpPort = config.ftpPort;
                    this.activeFolder = config.activeFolder;
                    this.archiveFolder = config.archiveFolder;
                    this.remotePath = config.remotePath;
                }
                catch (JsonException ex)
                {
                    // something went wrong serializing the config file
                    Console.WriteLine("Error parsing config file: " + ex.Message);

                }
            }

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