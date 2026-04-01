using System.Windows.Forms;

namespace TorrentCast
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.immediateTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.SelectAllDownloadsButton = new System.Windows.Forms.Button();
            this.DeleteDownloadButton = new System.Windows.Forms.Button();
            this.StartDownloadButton = new System.Windows.Forms.Button();
            this.RemoveDownloadButton = new System.Windows.Forms.Button();
            this.DownloadGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownloadTorrentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadTagCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownloadSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllActiveTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectAllActiveButton = new System.Windows.Forms.Button();
            this.MoveActiveToDownloadButton = new System.Windows.Forms.Button();
            this.DeleteActiveButton = new System.Windows.Forms.Button();
            this.activeGrid = new System.Windows.Forms.DataGridView();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.ResetSearchButton = new System.Windows.Forms.Button();
            this.SelectAllSearch = new System.Windows.Forms.Button();
            this.DownloadSearchButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FailedTab = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SelectAllDeleted = new System.Windows.Forms.Button();
            this.DownloadFailed = new System.Windows.Forms.Button();
            this.DeleteFailed = new System.Windows.Forms.Button();
            this.failedGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failedSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SelectAllArchived = new System.Windows.Forms.Button();
            this.DeleteArchived = new System.Windows.Forms.Button();
            this.archivedGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArchivedTorrentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArchiveSelectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tagTab = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.serverGrid = new System.Windows.Forms.DataGridView();
            this.serverCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectServer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SaveServerNameButton = new System.Windows.Forms.Button();
            this.deleteServer = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.OpenFoldersButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.remoteDirTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.porttextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TorrentNameActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverTagColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tabs.SuspendLayout();
            this.immediateTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadGrid)).BeginInit();
            this.AllActiveTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeGrid)).BeginInit();
            this.SearchTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.FailedTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.failedGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivedGrid)).BeginInit();
            this.tagTab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverGrid)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1345, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TorrentCast 1.0";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.immediateTab);
            this.Tabs.Controls.Add(this.AllActiveTab);
            this.Tabs.Controls.Add(this.SearchTab);
            this.Tabs.Controls.Add(this.FailedTab);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tagTab);
            this.Tabs.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1478, 1152);
            this.Tabs.TabIndex = 6;
            // 
            // immediateTab
            // 
            this.immediateTab.BackColor = System.Drawing.Color.Black;
            this.immediateTab.Controls.Add(this.groupBox3);
            this.immediateTab.Controls.Add(this.DownloadGrid);
            this.immediateTab.Location = new System.Drawing.Point(4, 30);
            this.immediateTab.Name = "immediateTab";
            this.immediateTab.Padding = new System.Windows.Forms.Padding(3);
            this.immediateTab.Size = new System.Drawing.Size(1470, 1118);
            this.immediateTab.TabIndex = 0;
            this.immediateTab.Text = "Download";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.SelectAllDownloadsButton);
            this.groupBox3.Controls.Add(this.DeleteDownloadButton);
            this.groupBox3.Controls.Add(this.StartDownloadButton);
            this.groupBox3.Controls.Add(this.RemoveDownloadButton);
            this.groupBox3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(3, 1019);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1461, 94);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(366, 33);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(1089, 43);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 7;
            // 
            // SelectAllDownloadsButton
            // 
            this.SelectAllDownloadsButton.BackColor = System.Drawing.Color.Gold;
            this.SelectAllDownloadsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectAllDownloadsButton.Location = new System.Drawing.Point(838, 33);
            this.SelectAllDownloadsButton.Name = "SelectAllDownloadsButton";
            this.SelectAllDownloadsButton.Size = new System.Drawing.Size(114, 41);
            this.SelectAllDownloadsButton.TabIndex = 6;
            this.SelectAllDownloadsButton.Text = "Select All";
            this.SelectAllDownloadsButton.UseVisualStyleBackColor = false;
            this.SelectAllDownloadsButton.Click += new System.EventHandler(this.SelectAllDownloadsButton_Click);
            // 
            // DeleteDownloadButton
            // 
            this.DeleteDownloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.DeleteDownloadButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDownloadButton.ForeColor = System.Drawing.Color.White;
            this.DeleteDownloadButton.Location = new System.Drawing.Point(246, 35);
            this.DeleteDownloadButton.Name = "DeleteDownloadButton";
            this.DeleteDownloadButton.Size = new System.Drawing.Size(114, 41);
            this.DeleteDownloadButton.TabIndex = 5;
            this.DeleteDownloadButton.Text = "Delete";
            this.DeleteDownloadButton.UseVisualStyleBackColor = false;
            this.DeleteDownloadButton.Click += new System.EventHandler(this.DeleteDownloadButton_Click);
            // 
            // StartDownloadButton
            // 
            this.StartDownloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.StartDownloadButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDownloadButton.ForeColor = System.Drawing.Color.White;
            this.StartDownloadButton.Location = new System.Drawing.Point(6, 35);
            this.StartDownloadButton.Name = "StartDownloadButton";
            this.StartDownloadButton.Size = new System.Drawing.Size(114, 41);
            this.StartDownloadButton.TabIndex = 4;
            this.StartDownloadButton.Text = "Download";
            this.StartDownloadButton.UseVisualStyleBackColor = false;
            this.StartDownloadButton.Click += new System.EventHandler(this.StartDownloadButton_Click);
            // 
            // RemoveDownloadButton
            // 
            this.RemoveDownloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.RemoveDownloadButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveDownloadButton.ForeColor = System.Drawing.Color.White;
            this.RemoveDownloadButton.Location = new System.Drawing.Point(126, 35);
            this.RemoveDownloadButton.Name = "RemoveDownloadButton";
            this.RemoveDownloadButton.Size = new System.Drawing.Size(114, 41);
            this.RemoveDownloadButton.TabIndex = 3;
            this.RemoveDownloadButton.Text = "Remove";
            this.RemoveDownloadButton.UseVisualStyleBackColor = false;
            this.RemoveDownloadButton.Click += new System.EventHandler(this.RemoveDownloadButton_Click);
            // 
            // DownloadGrid
            // 
            this.DownloadGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.DownloadGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DownloadGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.DownloadGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DownloadGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DownloadGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DownloadGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DownloadGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DownloadTorrentName,
            this.downloadTagCol,
            this.DownloadSelect});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DownloadGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.DownloadGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DownloadGrid.Location = new System.Drawing.Point(6, 6);
            this.DownloadGrid.Name = "DownloadGrid";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DownloadGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DownloadGrid.RowHeadersVisible = false;
            this.DownloadGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.DownloadGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DownloadGrid.RowTemplate.Height = 28;
            this.DownloadGrid.Size = new System.Drawing.Size(1458, 1007);
            this.DownloadGrid.TabIndex = 1;
            this.DownloadGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownloadGrid_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.DividerWidth = 2;
            this.dataGridViewTextBoxColumn1.HeaderText = "*";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // DownloadTorrentName
            // 
            this.DownloadTorrentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DownloadTorrentName.HeaderText = "Torrent Name";
            this.DownloadTorrentName.MinimumWidth = 200;
            this.DownloadTorrentName.Name = "DownloadTorrentName";
            this.DownloadTorrentName.ReadOnly = true;
            // 
            // downloadTagCol
            // 
            this.downloadTagCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.downloadTagCol.HeaderText = "Tags";
            this.downloadTagCol.MinimumWidth = 8;
            this.downloadTagCol.Name = "downloadTagCol";
            this.downloadTagCol.ReadOnly = true;
            // 
            // DownloadSelect
            // 
            this.DownloadSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DownloadSelect.HeaderText = "Select";
            this.DownloadSelect.MinimumWidth = 8;
            this.DownloadSelect.Name = "DownloadSelect";
            this.DownloadSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DownloadSelect.Width = 75;
            // 
            // AllActiveTab
            // 
            this.AllActiveTab.BackColor = System.Drawing.Color.Black;
            this.AllActiveTab.Controls.Add(this.groupBox2);
            this.AllActiveTab.Controls.Add(this.activeGrid);
            this.AllActiveTab.Location = new System.Drawing.Point(4, 30);
            this.AllActiveTab.Name = "AllActiveTab";
            this.AllActiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllActiveTab.Size = new System.Drawing.Size(1470, 1118);
            this.AllActiveTab.TabIndex = 1;
            this.AllActiveTab.Text = "All";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.SelectAllActiveButton);
            this.groupBox2.Controls.Add(this.MoveActiveToDownloadButton);
            this.groupBox2.Controls.Add(this.DeleteActiveButton);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(4, 1025);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1463, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // SelectAllActiveButton
            // 
            this.SelectAllActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.SelectAllActiveButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.SelectAllActiveButton.ForeColor = System.Drawing.Color.White;
            this.SelectAllActiveButton.Location = new System.Drawing.Point(1343, 25);
            this.SelectAllActiveButton.Name = "SelectAllActiveButton";
            this.SelectAllActiveButton.Size = new System.Drawing.Size(114, 41);
            this.SelectAllActiveButton.TabIndex = 7;
            this.SelectAllActiveButton.Text = "Select All";
            this.SelectAllActiveButton.UseVisualStyleBackColor = false;
            this.SelectAllActiveButton.Click += new System.EventHandler(this.SelectAllActiveButton_Click);
            // 
            // MoveActiveToDownloadButton
            // 
            this.MoveActiveToDownloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.MoveActiveToDownloadButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.MoveActiveToDownloadButton.ForeColor = System.Drawing.Color.White;
            this.MoveActiveToDownloadButton.Location = new System.Drawing.Point(6, 25);
            this.MoveActiveToDownloadButton.Name = "MoveActiveToDownloadButton";
            this.MoveActiveToDownloadButton.Size = new System.Drawing.Size(188, 41);
            this.MoveActiveToDownloadButton.TabIndex = 4;
            this.MoveActiveToDownloadButton.Text = "Add to Queue";
            this.MoveActiveToDownloadButton.UseVisualStyleBackColor = false;
            this.MoveActiveToDownloadButton.Click += new System.EventHandler(this.MakeActiveButton_Click);
            // 
            // DeleteActiveButton
            // 
            this.DeleteActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.DeleteActiveButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.DeleteActiveButton.ForeColor = System.Drawing.Color.White;
            this.DeleteActiveButton.Location = new System.Drawing.Point(668, 25);
            this.DeleteActiveButton.Name = "DeleteActiveButton";
            this.DeleteActiveButton.Size = new System.Drawing.Size(114, 41);
            this.DeleteActiveButton.TabIndex = 3;
            this.DeleteActiveButton.Text = "Delete";
            this.DeleteActiveButton.UseVisualStyleBackColor = false;
            this.DeleteActiveButton.Click += new System.EventHandler(this.DeleteActiveButton_Click);
            // 
            // activeGrid
            // 
            this.activeGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.activeGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.activeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.activeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.activeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.TorrentNameActive,
            this.serverTagColumn,
            this.Select});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.activeGrid.GridColor = System.Drawing.Color.Gray;
            this.activeGrid.Location = new System.Drawing.Point(6, 6);
            this.activeGrid.Name = "activeGrid";
            this.activeGrid.RowHeadersVisible = false;
            this.activeGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activeGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.activeGrid.RowTemplate.Height = 28;
            this.activeGrid.Size = new System.Drawing.Size(1458, 1013);
            this.activeGrid.TabIndex = 1;
            this.activeGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveGrid_KeyDown);
            // 
            // SearchTab
            // 
            this.SearchTab.BackColor = System.Drawing.Color.Black;
            this.SearchTab.Controls.Add(this.groupBox4);
            this.SearchTab.Controls.Add(this.searchGrid);
            this.SearchTab.Location = new System.Drawing.Point(4, 30);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(1470, 1118);
            this.SearchTab.TabIndex = 2;
            this.SearchTab.Text = "Search";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.searchBox);
            this.groupBox4.Controls.Add(this.ResetSearchButton);
            this.groupBox4.Controls.Add(this.SelectAllSearch);
            this.groupBox4.Controls.Add(this.DownloadSearchButton);
            this.groupBox4.Controls.Add(this.SearchButton);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(9, 1019);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1458, 94);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(16, 40);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(335, 29);
            this.searchBox.TabIndex = 10;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchButtonHandler);
            // 
            // ResetSearchButton
            // 
            this.ResetSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.ResetSearchButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.ResetSearchButton.ForeColor = System.Drawing.Color.White;
            this.ResetSearchButton.Location = new System.Drawing.Point(477, 33);
            this.ResetSearchButton.Name = "ResetSearchButton";
            this.ResetSearchButton.Size = new System.Drawing.Size(114, 41);
            this.ResetSearchButton.TabIndex = 9;
            this.ResetSearchButton.Text = "Clear";
            this.ResetSearchButton.UseVisualStyleBackColor = false;
            this.ResetSearchButton.Click += new System.EventHandler(this.ResetSearchButton_Click);
            // 
            // SelectAllSearch
            // 
            this.SelectAllSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.SelectAllSearch.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.SelectAllSearch.ForeColor = System.Drawing.Color.White;
            this.SelectAllSearch.Location = new System.Drawing.Point(1338, 27);
            this.SelectAllSearch.Name = "SelectAllSearch";
            this.SelectAllSearch.Size = new System.Drawing.Size(114, 41);
            this.SelectAllSearch.TabIndex = 7;
            this.SelectAllSearch.Text = "Select All";
            this.SelectAllSearch.UseVisualStyleBackColor = false;
            this.SelectAllSearch.Click += new System.EventHandler(this.SelectAllSearch_Click);
            // 
            // DownloadSearchButton
            // 
            this.DownloadSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.DownloadSearchButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.DownloadSearchButton.ForeColor = System.Drawing.Color.White;
            this.DownloadSearchButton.Location = new System.Drawing.Point(597, 33);
            this.DownloadSearchButton.Name = "DownloadSearchButton";
            this.DownloadSearchButton.Size = new System.Drawing.Size(114, 41);
            this.DownloadSearchButton.TabIndex = 4;
            this.DownloadSearchButton.Text = "Download";
            this.DownloadSearchButton.UseVisualStyleBackColor = false;
            this.DownloadSearchButton.Click += new System.EventHandler(this.DownloadSearchButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.SearchButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(357, 33);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 41);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchGrid
            // 
            this.searchGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.searchGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.searchGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.searchTags,
            this.SearchSelect});
            this.searchGrid.Location = new System.Drawing.Point(5, 6);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.RowHeadersVisible = false;
            this.searchGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.searchGrid.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.searchGrid.RowTemplate.Height = 28;
            this.searchGrid.Size = new System.Drawing.Size(1458, 1007);
            this.searchGrid.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn4.DividerWidth = 2;
            this.dataGridViewTextBoxColumn4.HeaderText = "*";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn4.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Torrent Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // searchTags
            // 
            this.searchTags.HeaderText = "Tags";
            this.searchTags.MinimumWidth = 8;
            this.searchTags.Name = "searchTags";
            this.searchTags.Width = 150;
            // 
            // SearchSelect
            // 
            this.SearchSelect.HeaderText = "Select";
            this.SearchSelect.MinimumWidth = 8;
            this.SearchSelect.Name = "SearchSelect";
            this.SearchSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SearchSelect.Width = 150;
            // 
            // FailedTab
            // 
            this.FailedTab.BackColor = System.Drawing.Color.Black;
            this.FailedTab.Controls.Add(this.groupBox6);
            this.FailedTab.Controls.Add(this.failedGrid);
            this.FailedTab.Location = new System.Drawing.Point(4, 30);
            this.FailedTab.Name = "FailedTab";
            this.FailedTab.Padding = new System.Windows.Forms.Padding(3);
            this.FailedTab.Size = new System.Drawing.Size(1470, 1118);
            this.FailedTab.TabIndex = 4;
            this.FailedTab.Text = "Failed";
            this.FailedTab.Click += new System.EventHandler(this.FailedTab_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.groupBox6.Controls.Add(this.SelectAllDeleted);
            this.groupBox6.Controls.Add(this.DownloadFailed);
            this.groupBox6.Controls.Add(this.DeleteFailed);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Location = new System.Drawing.Point(9, 1019);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1458, 94);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Controls";
            // 
            // SelectAllDeleted
            // 
            this.SelectAllDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.SelectAllDeleted.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.SelectAllDeleted.ForeColor = System.Drawing.Color.White;
            this.SelectAllDeleted.Location = new System.Drawing.Point(1327, 25);
            this.SelectAllDeleted.Name = "SelectAllDeleted";
            this.SelectAllDeleted.Size = new System.Drawing.Size(114, 41);
            this.SelectAllDeleted.TabIndex = 7;
            this.SelectAllDeleted.Text = "Select All";
            this.SelectAllDeleted.UseVisualStyleBackColor = false;
            this.SelectAllDeleted.Click += new System.EventHandler(this.SelectAllDeleted_Click);
            // 
            // DownloadFailed
            // 
            this.DownloadFailed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.DownloadFailed.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.DownloadFailed.ForeColor = System.Drawing.Color.White;
            this.DownloadFailed.Location = new System.Drawing.Point(6, 25);
            this.DownloadFailed.Name = "DownloadFailed";
            this.DownloadFailed.Size = new System.Drawing.Size(114, 41);
            this.DownloadFailed.TabIndex = 4;
            this.DownloadFailed.Text = "Recover";
            this.DownloadFailed.UseVisualStyleBackColor = false;
            this.DownloadFailed.Click += new System.EventHandler(this.DownloadFailed_Click);
            // 
            // DeleteFailed
            // 
            this.DeleteFailed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.DeleteFailed.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.DeleteFailed.ForeColor = System.Drawing.Color.White;
            this.DeleteFailed.Location = new System.Drawing.Point(126, 25);
            this.DeleteFailed.Name = "DeleteFailed";
            this.DeleteFailed.Size = new System.Drawing.Size(114, 41);
            this.DeleteFailed.TabIndex = 3;
            this.DeleteFailed.Text = "Delete";
            this.DeleteFailed.UseVisualStyleBackColor = false;
            this.DeleteFailed.Click += new System.EventHandler(this.DeleteFailed_Click);
            // 
            // failedGrid
            // 
            this.failedGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.failedGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.failedGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.failedGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.failedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.failedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.failedSelected});
            this.failedGrid.Location = new System.Drawing.Point(5, 6);
            this.failedGrid.Name = "failedGrid";
            this.failedGrid.RowHeadersVisible = false;
            this.failedGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.failedGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.failedGrid.RowTemplate.Height = 28;
            this.failedGrid.Size = new System.Drawing.Size(1458, 1007);
            this.failedGrid.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn10.DividerWidth = 2;
            this.dataGridViewTextBoxColumn10.HeaderText = "*";
            this.dataGridViewTextBoxColumn10.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn10.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 40;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Torrent Name";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "path";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // failedSelected
            // 
            this.failedSelected.HeaderText = "Select";
            this.failedSelected.MinimumWidth = 8;
            this.failedSelected.Name = "failedSelected";
            this.failedSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.failedSelected.Width = 150;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.archivedGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1470, 1118);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Archive";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.groupBox5.Controls.Add(this.SelectAllArchived);
            this.groupBox5.Controls.Add(this.DeleteArchived);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(5, 1019);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1458, 94);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // SelectAllArchived
            // 
            this.SelectAllArchived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.SelectAllArchived.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.SelectAllArchived.ForeColor = System.Drawing.Color.White;
            this.SelectAllArchived.Location = new System.Drawing.Point(1338, 25);
            this.SelectAllArchived.Name = "SelectAllArchived";
            this.SelectAllArchived.Size = new System.Drawing.Size(114, 41);
            this.SelectAllArchived.TabIndex = 7;
            this.SelectAllArchived.Text = "Select All";
            this.SelectAllArchived.UseVisualStyleBackColor = false;
            this.SelectAllArchived.Click += new System.EventHandler(this.SelectAllArchived_Click);
            // 
            // DeleteArchived
            // 
            this.DeleteArchived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.DeleteArchived.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.DeleteArchived.ForeColor = System.Drawing.Color.White;
            this.DeleteArchived.Location = new System.Drawing.Point(6, 25);
            this.DeleteArchived.Name = "DeleteArchived";
            this.DeleteArchived.Size = new System.Drawing.Size(114, 41);
            this.DeleteArchived.TabIndex = 3;
            this.DeleteArchived.Text = "Delete";
            this.DeleteArchived.UseVisualStyleBackColor = false;
            this.DeleteArchived.Click += new System.EventHandler(this.DeleteArchived_Click);
            // 
            // archivedGrid
            // 
            this.archivedGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.archivedGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.archivedGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archivedGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.archivedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivedGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.ArchivedTorrentName,
            this.dataGridViewTextBoxColumn9,
            this.ArchiveSelectColumn});
            this.archivedGrid.Location = new System.Drawing.Point(5, 6);
            this.archivedGrid.Name = "archivedGrid";
            this.archivedGrid.RowHeadersVisible = false;
            this.archivedGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.archivedGrid.RowsDefaultCellStyle = dataGridViewCellStyle19;
            this.archivedGrid.RowTemplate.Height = 28;
            this.archivedGrid.Size = new System.Drawing.Size(1458, 1007);
            this.archivedGrid.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn7.DividerWidth = 2;
            this.dataGridViewTextBoxColumn7.HeaderText = "*";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn7.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // ArchivedTorrentName
            // 
            this.ArchivedTorrentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArchivedTorrentName.HeaderText = "Torrent Name";
            this.ArchivedTorrentName.MinimumWidth = 200;
            this.ArchivedTorrentName.Name = "ArchivedTorrentName";
            this.ArchivedTorrentName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "path";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // ArchiveSelectColumn
            // 
            this.ArchiveSelectColumn.HeaderText = "Select";
            this.ArchiveSelectColumn.MinimumWidth = 8;
            this.ArchiveSelectColumn.Name = "ArchiveSelectColumn";
            this.ArchiveSelectColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ArchiveSelectColumn.Width = 150;
            // 
            // tagTab
            // 
            this.tagTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.tagTab.Controls.Add(this.label1);
            this.tagTab.Controls.Add(this.groupBox8);
            this.tagTab.Controls.Add(this.groupBox7);
            this.tagTab.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.tagTab.Location = new System.Drawing.Point(4, 30);
            this.tagTab.Name = "tagTab";
            this.tagTab.Padding = new System.Windows.Forms.Padding(3);
            this.tagTab.Size = new System.Drawing.Size(1470, 1118);
            this.tagTab.TabIndex = 6;
            this.tagTab.Text = "Config";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.groupBox8.Controls.Add(this.serverGrid);
            this.groupBox8.Controls.Add(this.SaveServerNameButton);
            this.groupBox8.Controls.Add(this.deleteServer);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(6, 352);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1458, 761);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Announce Server and  Tags";
            // 
            // serverGrid
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.serverGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.serverGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serverGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.serverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverCol,
            this.Tag,
            this.SelectServer});
            this.serverGrid.Location = new System.Drawing.Point(6, 25);
            this.serverGrid.Name = "serverGrid";
            this.serverGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(0)))));
            this.serverGrid.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.serverGrid.RowTemplate.Height = 28;
            this.serverGrid.Size = new System.Drawing.Size(1446, 683);
            this.serverGrid.TabIndex = 0;
            // 
            // serverCol
            // 
            this.serverCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serverCol.FillWeight = 86.07954F;
            this.serverCol.HeaderText = "Announce Url";
            this.serverCol.MinimumWidth = 8;
            this.serverCol.Name = "serverCol";
            this.serverCol.ReadOnly = true;
            // 
            // Tag
            // 
            this.Tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tag.FillWeight = 86.07954F;
            this.Tag.HeaderText = "Server";
            this.Tag.MinimumWidth = 8;
            this.Tag.Name = "Tag";
            // 
            // SelectServer
            // 
            this.SelectServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SelectServer.FillWeight = 127.8409F;
            this.SelectServer.HeaderText = "Select";
            this.SelectServer.MinimumWidth = 8;
            this.SelectServer.Name = "SelectServer";
            this.SelectServer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectServer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectServer.Width = 75;
            // 
            // SaveServerNameButton
            // 
            this.SaveServerNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.SaveServerNameButton.ForeColor = System.Drawing.Color.White;
            this.SaveServerNameButton.Location = new System.Drawing.Point(6, 714);
            this.SaveServerNameButton.Name = "SaveServerNameButton";
            this.SaveServerNameButton.Size = new System.Drawing.Size(304, 41);
            this.SaveServerNameButton.TabIndex = 9;
            this.SaveServerNameButton.Text = "Save";
            this.SaveServerNameButton.UseVisualStyleBackColor = false;
            this.SaveServerNameButton.Click += new System.EventHandler(this.SaveServerNameButton_Click);
            // 
            // deleteServer
            // 
            this.deleteServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.deleteServer.ForeColor = System.Drawing.Color.White;
            this.deleteServer.Location = new System.Drawing.Point(1148, 714);
            this.deleteServer.Name = "deleteServer";
            this.deleteServer.Size = new System.Drawing.Size(304, 41);
            this.deleteServer.TabIndex = 10;
            this.deleteServer.Text = "Delete Selected";
            this.deleteServer.UseVisualStyleBackColor = false;
            this.deleteServer.Click += new System.EventHandler(this.deleteServer_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.groupBox7.Controls.Add(this.OpenFoldersButton);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.remoteDirTextbox);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.porttextbox);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.passwordTextbox);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.usernameTextbox);
            this.groupBox7.Controls.Add(this.urlLabel);
            this.groupBox7.Controls.Add(this.urlTextbox);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(12, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(631, 328);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Server Details";
            // 
            // OpenFoldersButton
            // 
            this.OpenFoldersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.OpenFoldersButton.ForeColor = System.Drawing.Color.White;
            this.OpenFoldersButton.Location = new System.Drawing.Point(345, 244);
            this.OpenFoldersButton.Name = "OpenFoldersButton";
            this.OpenFoldersButton.Size = new System.Drawing.Size(114, 41);
            this.OpenFoldersButton.TabIndex = 13;
            this.OpenFoldersButton.Text = "Folders";
            this.OpenFoldersButton.UseVisualStyleBackColor = false;
            this.OpenFoldersButton.Click += new System.EventHandler(this.OpenFoldersButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remote Dir";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(477, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // remoteDirTextbox
            // 
            this.remoteDirTextbox.Location = new System.Drawing.Point(111, 198);
            this.remoteDirTextbox.Name = "remoteDirTextbox";
            this.remoteDirTextbox.Size = new System.Drawing.Size(506, 30);
            this.remoteDirTextbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port";
            // 
            // porttextbox
            // 
            this.porttextbox.Location = new System.Drawing.Point(112, 246);
            this.porttextbox.Name = "porttextbox";
            this.porttextbox.Size = new System.Drawing.Size(87, 30);
            this.porttextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(112, 151);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(505, 30);
            this.passwordTextbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Login";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(111, 99);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(506, 30);
            this.usernameTextbox.TabIndex = 2;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(15, 48);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(81, 25);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "Server Url";
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(111, 45);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(506, 30);
            this.urlTextbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(979, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.count.DefaultCellStyle = dataGridViewCellStyle8;
            this.count.DividerWidth = 2;
            this.count.Frozen = true;
            this.count.HeaderText = "*";
            this.count.MaxInputLength = 3;
            this.count.MinimumWidth = 40;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.count.Width = 40;
            // 
            // TorrentNameActive
            // 
            this.TorrentNameActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TorrentNameActive.HeaderText = "Torrent Name";
            this.TorrentNameActive.MinimumWidth = 200;
            this.TorrentNameActive.Name = "TorrentNameActive";
            // 
            // serverTagColumn
            // 
            this.serverTagColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.serverTagColumn.HeaderText = "tags";
            this.serverTagColumn.MinimumWidth = 8;
            this.serverTagColumn.Name = "serverTagColumn";
            this.serverTagColumn.ReadOnly = true;
            this.serverTagColumn.Width = 500;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Select.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1502, 1168);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1524, 1224);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1524, 1224);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TorrentCast";
            this.Tabs.ResumeLayout(false);
            this.immediateTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DownloadGrid)).EndInit();
            this.AllActiveTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activeGrid)).EndInit();
            this.SearchTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.FailedTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.failedGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.archivedGrid)).EndInit();
            this.tagTab.ResumeLayout(false);
            this.tagTab.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverGrid)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private TabControl Tabs;
        private TabPage immediateTab;
        private TabPage AllActiveTab;
        private TabPage SearchTab;
        private TabPage FailedTab;
        private DataGridView DownloadGrid;
        private GroupBox groupBox2;
        private Button MoveActiveToDownloadButton;
        private Button DeleteActiveButton;
        private DataGridView activeGrid;
        private GroupBox groupBox3;
        private Button StartDownloadButton;
        private Button RemoveDownloadButton;
        private Button DeleteDownloadButton;
        private Button SelectAllDownloadsButton;
        private Button SelectAllActiveButton;
        private GroupBox groupBox4;
        private Button SelectAllSearch;
        private Button DownloadSearchButton;
        private Button SearchButton;
        private DataGridView searchGrid;
        private GroupBox groupBox6;
        private Button SelectAllDeleted;
        private Button DownloadFailed;
        private Button DeleteFailed;
        private DataGridView failedGrid;
        private Button ResetSearchButton;
        private ComboBox searchBox;
        private TabPage tabPage1;
        private GroupBox groupBox5;
        private Button SelectAllArchived;
        private Button DeleteArchived;
        private DataGridView archivedGrid;
        private ProgressBar progressBar2;
        private TabPage tagTab;
        private DataGridView serverGrid;
        private Button SaveServerNameButton;
        private Button deleteServer;
        private GroupBox groupBox8;
        private GroupBox groupBox7;
        private Label label4;
        private Button button2;
        private TextBox remoteDirTextbox;
        private Label label3;
        private TextBox porttextbox;
        private Label label2;
        private TextBox passwordTextbox;
        private Label label5;
        private TextBox usernameTextbox;
        private Label urlLabel;
        private TextBox urlTextbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private DataGridViewTextBoxColumn serverCol;
        private DataGridViewTextBoxColumn Tag;
        private DataGridViewCheckBoxColumn SelectServer;
        private Button OpenFoldersButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DownloadTorrentName;
        private DataGridViewTextBoxColumn downloadTagCol;
        private DataGridViewCheckBoxColumn DownloadSelect;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn searchTags;
        private DataGridViewCheckBoxColumn SearchSelect;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewCheckBoxColumn failedSelected;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn ArchivedTorrentName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewCheckBoxColumn ArchiveSelectColumn;
        private Button button1;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn TorrentNameActive;
        private DataGridViewTextBoxColumn serverTagColumn;
        private DataGridViewCheckBoxColumn Select;
    }
}

