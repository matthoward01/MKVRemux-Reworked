
namespace MKVSubFixer
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOutputDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckSearch = new System.Windows.Forms.CheckBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchLanguage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboLanguage = new System.Windows.Forms.ComboBox();
            this.comboTrack = new System.Windows.Forms.ComboBox();
            this.SearchTrack = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPrecheck = new System.Windows.Forms.Button();
            this.buttonRemux = new System.Windows.Forms.Button();
            this.TrackList = new System.Windows.Forms.ListBox();
            this.bMkvToolNix = new System.Windows.Forms.Button();
            this.fbdMkvToolNix = new System.Windows.Forms.FolderBrowserDialog();
            this.comboSearchName = new System.Windows.Forms.ComboBox();
            this.tbNewTrackNum = new System.Windows.Forms.TextBox();
            this.butInputDir = new System.Windows.Forms.Button();
            this.butOutputDir = new System.Windows.Forms.Button();
            this.fbdInputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdOutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkSubDir = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Directory";
            // 
            // tbInputDir
            // 
            this.tbInputDir.Location = new System.Drawing.Point(102, 43);
            this.tbInputDir.Name = "tbInputDir";
            this.tbInputDir.Size = new System.Drawing.Size(554, 20);
            this.tbInputDir.TabIndex = 1;
            this.tbInputDir.Leave += new System.EventHandler(this.InputDir_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Directory";
            // 
            // tbOutputDir
            // 
            this.tbOutputDir.Location = new System.Drawing.Point(102, 74);
            this.tbOutputDir.Name = "tbOutputDir";
            this.tbOutputDir.Size = new System.Drawing.Size(554, 20);
            this.tbOutputDir.TabIndex = 3;
            this.tbOutputDir.Leave += new System.EventHandler(this.OutputDir_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Name";
            // 
            // CheckSearch
            // 
            this.CheckSearch.AutoSize = true;
            this.CheckSearch.Location = new System.Drawing.Point(13, 110);
            this.CheckSearch.Name = "CheckSearch";
            this.CheckSearch.Size = new System.Drawing.Size(15, 14);
            this.CheckSearch.TabIndex = 6;
            this.CheckSearch.UseVisualStyleBackColor = true;
            this.CheckSearch.CheckedChanged += new System.EventHandler(this.CheckSearch_CheckedChanged);
            // 
            // SearchText
            // 
            this.SearchText.Enabled = false;
            this.SearchText.Location = new System.Drawing.Point(102, 107);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(96, 20);
            this.SearchText.TabIndex = 7;
            // 
            // SearchLanguage
            // 
            this.SearchLanguage.Location = new System.Drawing.Point(339, 107);
            this.SearchLanguage.Name = "SearchLanguage";
            this.SearchLanguage.Size = new System.Drawing.Size(44, 20);
            this.SearchLanguage.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search Lang";
            // 
            // ComboLanguage
            // 
            this.ComboLanguage.FormattingEnabled = true;
            this.ComboLanguage.Items.AddRange(new object[] {
            "eng",
            "jpn"});
            this.ComboLanguage.Location = new System.Drawing.Point(389, 106);
            this.ComboLanguage.Name = "ComboLanguage";
            this.ComboLanguage.Size = new System.Drawing.Size(56, 21);
            this.ComboLanguage.TabIndex = 10;
            // 
            // comboTrack
            // 
            this.comboTrack.FormattingEnabled = true;
            this.comboTrack.Items.AddRange(new object[] {
            "eng",
            "jpn"});
            this.comboTrack.Location = new System.Drawing.Point(567, 107);
            this.comboTrack.Name = "comboTrack";
            this.comboTrack.Size = new System.Drawing.Size(56, 21);
            this.comboTrack.TabIndex = 13;
            // 
            // SearchTrack
            // 
            this.SearchTrack.Location = new System.Drawing.Point(532, 107);
            this.SearchTrack.Name = "SearchTrack";
            this.SearchTrack.Size = new System.Drawing.Size(29, 20);
            this.SearchTrack.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search Track";
            // 
            // buttonPrecheck
            // 
            this.buttonPrecheck.Enabled = false;
            this.buttonPrecheck.Location = new System.Drawing.Point(12, 267);
            this.buttonPrecheck.Name = "buttonPrecheck";
            this.buttonPrecheck.Size = new System.Drawing.Size(262, 23);
            this.buttonPrecheck.TabIndex = 15;
            this.buttonPrecheck.Text = "PreCheck";
            this.buttonPrecheck.UseVisualStyleBackColor = true;
            this.buttonPrecheck.Click += new System.EventHandler(this.buttonPrecheck_Click);
            // 
            // buttonRemux
            // 
            this.buttonRemux.Enabled = false;
            this.buttonRemux.Location = new System.Drawing.Point(280, 267);
            this.buttonRemux.Name = "buttonRemux";
            this.buttonRemux.Size = new System.Drawing.Size(246, 23);
            this.buttonRemux.TabIndex = 16;
            this.buttonRemux.Text = "Remux";
            this.buttonRemux.UseVisualStyleBackColor = true;
            this.buttonRemux.Click += new System.EventHandler(this.buttonRemux_Click);
            // 
            // TrackList
            // 
            this.TrackList.FormattingEnabled = true;
            this.TrackList.Location = new System.Drawing.Point(12, 140);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(514, 121);
            this.TrackList.TabIndex = 19;
            // 
            // bMkvToolNix
            // 
            this.bMkvToolNix.Location = new System.Drawing.Point(612, 12);
            this.bMkvToolNix.Name = "bMkvToolNix";
            this.bMkvToolNix.Size = new System.Drawing.Size(75, 23);
            this.bMkvToolNix.TabIndex = 21;
            this.bMkvToolNix.Text = "MKVToolNix";
            this.bMkvToolNix.UseVisualStyleBackColor = true;
            this.bMkvToolNix.Click += new System.EventHandler(this.bMkvToolNix_Click);
            // 
            // comboSearchName
            // 
            this.comboSearchName.Enabled = false;
            this.comboSearchName.FormattingEnabled = true;
            this.comboSearchName.Items.AddRange(new object[] {
            "eng",
            "jpn"});
            this.comboSearchName.Location = new System.Drawing.Point(204, 107);
            this.comboSearchName.Name = "comboSearchName";
            this.comboSearchName.Size = new System.Drawing.Size(56, 21);
            this.comboSearchName.TabIndex = 22;
            // 
            // tbNewTrackNum
            // 
            this.tbNewTrackNum.Location = new System.Drawing.Point(629, 108);
            this.tbNewTrackNum.Name = "tbNewTrackNum";
            this.tbNewTrackNum.Size = new System.Drawing.Size(29, 20);
            this.tbNewTrackNum.TabIndex = 23;
            // 
            // butInputDir
            // 
            this.butInputDir.Location = new System.Drawing.Point(662, 43);
            this.butInputDir.Name = "butInputDir";
            this.butInputDir.Size = new System.Drawing.Size(25, 23);
            this.butInputDir.TabIndex = 24;
            this.butInputDir.Text = "...";
            this.butInputDir.UseVisualStyleBackColor = true;
            this.butInputDir.Click += new System.EventHandler(this.butInputDir_Click);
            // 
            // butOutputDir
            // 
            this.butOutputDir.Location = new System.Drawing.Point(662, 72);
            this.butOutputDir.Name = "butOutputDir";
            this.butOutputDir.Size = new System.Drawing.Size(25, 23);
            this.butOutputDir.TabIndex = 25;
            this.butOutputDir.Text = "...";
            this.butOutputDir.UseVisualStyleBackColor = true;
            this.butOutputDir.Click += new System.EventHandler(this.butOutputDir_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // checkSubDir
            // 
            this.checkSubDir.AutoSize = true;
            this.checkSubDir.Location = new System.Drawing.Point(12, 12);
            this.checkSubDir.Name = "checkSubDir";
            this.checkSubDir.Size = new System.Drawing.Size(136, 17);
            this.checkSubDir.TabIndex = 26;
            this.checkSubDir.Text = "Include Sub Directories";
            this.checkSubDir.UseVisualStyleBackColor = true;
            this.checkSubDir.CheckedChanged += new System.EventHandler(this.checkSubDir_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MKVSubFixer.Properties.Resources.processing2;
            this.pictureBox1.Location = new System.Drawing.Point(537, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkSubDir);
            this.Controls.Add(this.butOutputDir);
            this.Controls.Add(this.butInputDir);
            this.Controls.Add(this.tbNewTrackNum);
            this.Controls.Add(this.comboSearchName);
            this.Controls.Add(this.bMkvToolNix);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.buttonRemux);
            this.Controls.Add(this.buttonPrecheck);
            this.Controls.Add(this.comboTrack);
            this.Controls.Add(this.SearchTrack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboLanguage);
            this.Controls.Add(this.SearchLanguage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.CheckSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOutputDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInputDir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mkv Remux";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOutputDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckSearch;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.TextBox SearchLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboLanguage;
        private System.Windows.Forms.ComboBox comboTrack;
        private System.Windows.Forms.TextBox SearchTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPrecheck;
        private System.Windows.Forms.Button buttonRemux;
        private System.Windows.Forms.ListBox TrackList;
        private System.Windows.Forms.Button bMkvToolNix;
        private System.Windows.Forms.FolderBrowserDialog fbdMkvToolNix;
        private System.Windows.Forms.ComboBox comboSearchName;
        private System.Windows.Forms.TextBox tbNewTrackNum;
        private System.Windows.Forms.Button butInputDir;
        private System.Windows.Forms.Button butOutputDir;
        private System.Windows.Forms.FolderBrowserDialog fbdInputDir;
        private System.Windows.Forms.FolderBrowserDialog fbdOutputDir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkSubDir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

