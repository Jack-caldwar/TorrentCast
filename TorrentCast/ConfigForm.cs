using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrentCast
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            ApplicationConfig config = new ApplicationConfig();
            config.LoadConfig();
            displayConfig(config);

        }

        private void displayConfig(ApplicationConfig config)
        {
            // Display the configuration in the form controls
            usernameTextbox.Text = config.username;
            passwordTextbox.Text = config.password;
            urlTextbox.Text = config.ftpHost;
            porttextbox.Text = config.ftpPort;
            remoteDirTextbox.Text = config.remotePath;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationConfig config = new ApplicationConfig();
            config.username = usernameTextbox.Text;
            config.password = passwordTextbox.Text;
            config.ftpHost = urlTextbox.Text;
            config.ftpPort = porttextbox.Text;
            config.remotePath = remoteDirTextbox.Text;
            config.SaveConfig();
            MessageBox.Show("Configuration Updated!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }
    }
}
