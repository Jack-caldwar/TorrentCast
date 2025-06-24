using System;
using System.Diagnostics;
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
            string password = cryptoKit.DecryptString(config.password);
            passwordTextbox.Text = config.password;
            urlTextbox.Text = config.ftpHost;
            porttextbox.Text = config.ftpPort;
            remoteDirTextbox.Text = config.remotePath;
            // mb.Text = cryptoKit.GetMotherboardSerial() ?? "Unknown Motherboard Serial";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(usernameTextbox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextbox.Text) ||
                string.IsNullOrWhiteSpace(urlTextbox.Text) ||
                string.IsNullOrWhiteSpace(porttextbox.Text) ||
                string.IsNullOrWhiteSpace(remoteDirTextbox.Text)
                )
            {
                MessageBox.Show("You need to fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Configuration Updated!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }
    }
}
