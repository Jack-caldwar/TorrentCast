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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.torrentCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.immediateTab = new System.Windows.Forms.TabPage();
            this.AllActiveTab = new System.Windows.Forms.TabPage();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.TagTab = new System.Windows.Forms.TabPage();
            this.FailedTab = new System.Windows.Forms.TabPage();
            this.DownloadGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MakeActiveButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.activeGrid = new System.Windows.Forms.DataGridView();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TorrentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownloadSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.immediateTab.SuspendLayout();
            this.AllActiveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(16, 1016);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(6, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Failed";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(126, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Archived";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(831, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(366, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(246, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Config";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(875, 893);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TorrentCast 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(18, 893);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pending Torrents:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // torrentCount
            // 
            this.torrentCount.AutoSize = true;
            this.torrentCount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.torrentCount.Location = new System.Drawing.Point(158, 893);
            this.torrentCount.Name = "torrentCount";
            this.torrentCount.Size = new System.Drawing.Size(18, 20);
            this.torrentCount.TabIndex = 4;
            this.torrentCount.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 1118);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(978, 43);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.immediateTab);
            this.Tabs.Controls.Add(this.AllActiveTab);
            this.Tabs.Controls.Add(this.SearchTab);
            this.Tabs.Controls.Add(this.TagTab);
            this.Tabs.Controls.Add(this.FailedTab);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(978, 878);
            this.Tabs.TabIndex = 6;
            // 
            // immediateTab
            // 
            this.immediateTab.Controls.Add(this.DownloadGrid);
            this.immediateTab.Location = new System.Drawing.Point(4, 29);
            this.immediateTab.Name = "immediateTab";
            this.immediateTab.Padding = new System.Windows.Forms.Padding(3);
            this.immediateTab.Size = new System.Drawing.Size(970, 845);
            this.immediateTab.TabIndex = 0;
            this.immediateTab.Text = "Download";
            this.immediateTab.UseVisualStyleBackColor = true;
            // 
            // AllActiveTab
            // 
            this.AllActiveTab.Controls.Add(this.activeGrid);
            this.AllActiveTab.Location = new System.Drawing.Point(4, 29);
            this.AllActiveTab.Name = "AllActiveTab";
            this.AllActiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllActiveTab.Size = new System.Drawing.Size(970, 845);
            this.AllActiveTab.TabIndex = 1;
            this.AllActiveTab.Text = "All";
            this.AllActiveTab.UseVisualStyleBackColor = true;
            // 
            // SearchTab
            // 
            this.SearchTab.Location = new System.Drawing.Point(4, 29);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(970, 360);
            this.SearchTab.TabIndex = 2;
            this.SearchTab.Text = "Search";
            this.SearchTab.UseVisualStyleBackColor = true;
            // 
            // TagTab
            // 
            this.TagTab.Location = new System.Drawing.Point(4, 29);
            this.TagTab.Name = "TagTab";
            this.TagTab.Padding = new System.Windows.Forms.Padding(3);
            this.TagTab.Size = new System.Drawing.Size(970, 360);
            this.TagTab.TabIndex = 3;
            this.TagTab.Text = "Tags";
            this.TagTab.UseVisualStyleBackColor = true;
            // 
            // FailedTab
            // 
            this.FailedTab.Location = new System.Drawing.Point(4, 29);
            this.FailedTab.Name = "FailedTab";
            this.FailedTab.Padding = new System.Windows.Forms.Padding(3);
            this.FailedTab.Size = new System.Drawing.Size(970, 360);
            this.FailedTab.TabIndex = 4;
            this.FailedTab.Text = "Failed";
            this.FailedTab.UseVisualStyleBackColor = true;
            // 
            // DownloadGrid
            // 
            this.DownloadGrid.AllowUserToAddRows = false;
            this.DownloadGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DownloadGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DownloadSelect});
            this.DownloadGrid.Location = new System.Drawing.Point(6, 6);
            this.DownloadGrid.Name = "DownloadGrid";
            this.DownloadGrid.RowHeadersVisible = false;
            this.DownloadGrid.RowHeadersWidth = 62;
            this.DownloadGrid.RowTemplate.Height = 28;
            this.DownloadGrid.Size = new System.Drawing.Size(958, 732);
            this.DownloadGrid.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Controls.Add(this.MakeActiveButton);
            this.groupBox2.Controls.Add(this.DeleteSelectedButton);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(16, 916);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // MakeActiveButton
            // 
            this.MakeActiveButton.BackColor = System.Drawing.Color.Gold;
            this.MakeActiveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MakeActiveButton.Location = new System.Drawing.Point(6, 25);
            this.MakeActiveButton.Name = "MakeActiveButton";
            this.MakeActiveButton.Size = new System.Drawing.Size(114, 41);
            this.MakeActiveButton.TabIndex = 4;
            this.MakeActiveButton.Text = "Download";
            this.MakeActiveButton.UseVisualStyleBackColor = false;
            this.MakeActiveButton.Click += new System.EventHandler(this.MakeActiveButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.BackColor = System.Drawing.Color.Gold;
            this.DeleteSelectedButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(126, 25);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(114, 41);
            this.DeleteSelectedButton.TabIndex = 3;
            this.DeleteSelectedButton.Text = "Remove";
            this.DeleteSelectedButton.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gold;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(831, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 41);
            this.button8.TabIndex = 2;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gold;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(714, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 41);
            this.button9.TabIndex = 1;
            this.button9.Text = "Go";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gold;
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(594, 25);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(114, 41);
            this.button10.TabIndex = 0;
            this.button10.Text = "Config";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // activeGrid
            // 
            this.activeGrid.AllowUserToAddRows = false;
            this.activeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.TorrentName,
            this.path,
            this.Select});
            this.activeGrid.Location = new System.Drawing.Point(6, 6);
            this.activeGrid.Name = "activeGrid";
            this.activeGrid.RowHeadersVisible = false;
            this.activeGrid.RowHeadersWidth = 62;
            this.activeGrid.RowTemplate.Height = 28;
            this.activeGrid.Size = new System.Drawing.Size(958, 833);
            this.activeGrid.TabIndex = 1;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.count.DefaultCellStyle = dataGridViewCellStyle2;
            this.count.DividerWidth = 2;
            this.count.HeaderText = "*";
            this.count.MaxInputLength = 3;
            this.count.MinimumWidth = 40;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.count.Width = 40;
            // 
            // TorrentName
            // 
            this.TorrentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TorrentName.HeaderText = "Torrent Name";
            this.TorrentName.MinimumWidth = 200;
            this.TorrentName.Name = "TorrentName";
            this.TorrentName.ReadOnly = true;
            // 
            // path
            // 
            this.path.HeaderText = "path";
            this.path.MinimumWidth = 8;
            this.path.Name = "path";
            this.path.Visible = false;
            this.path.Width = 150;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.DividerWidth = 2;
            this.dataGridViewTextBoxColumn1.HeaderText = "*";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 3;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Torrent Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "path";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // DownloadSelect
            // 
            this.DownloadSelect.HeaderText = "Select";
            this.DownloadSelect.MinimumWidth = 8;
            this.DownloadSelect.Name = "DownloadSelect";
            this.DownloadSelect.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1002, 1168);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.torrentCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 1224);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 1224);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TorrentCast";
            this.groupBox1.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.immediateTab.ResumeLayout(false);
            this.AllActiveTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DownloadGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Button button4;
        private Button button5;
        private Label label2;
        private Label torrentCount;
        private ProgressBar progressBar1;
        private TabControl Tabs;
        private TabPage immediateTab;
        private TabPage AllActiveTab;
        private TabPage SearchTab;
        private TabPage TagTab;
        private TabPage FailedTab;
        private DataGridView DownloadGrid;
        private GroupBox groupBox2;
        private Button MakeActiveButton;
        private Button DeleteSelectedButton;
        private Button button8;
        private Button button9;
        private Button button10;
        private DataGridView activeGrid;
        private DataGridViewTextBoxColumn count;
        private DataGridViewTextBoxColumn TorrentName;
        private DataGridViewTextBoxColumn path;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn DownloadSelect;
    }
}

