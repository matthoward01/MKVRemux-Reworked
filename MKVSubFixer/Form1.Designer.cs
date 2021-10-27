
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
            this.InputDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputDir = new System.Windows.Forms.TextBox();
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
            this.TrackListRemux = new System.Windows.Forms.ListBox();
            this.TrackList = new System.Windows.Forms.ListBox();
            this.bMkvToolNix = new System.Windows.Forms.Button();
            this.fbdMkvToolNix = new System.Windows.Forms.FolderBrowserDialog();
            this.comboSearchName = new System.Windows.Forms.ComboBox();
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
            // InputDir
            // 
            this.InputDir.Location = new System.Drawing.Point(102, 43);
            this.InputDir.Name = "InputDir";
            this.InputDir.Size = new System.Drawing.Size(581, 20);
            this.InputDir.TabIndex = 1;
            this.InputDir.Leave += new System.EventHandler(this.InputDir_Leave);
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
            // OutputDir
            // 
            this.OutputDir.Location = new System.Drawing.Point(102, 74);
            this.OutputDir.Name = "OutputDir";
            this.OutputDir.Size = new System.Drawing.Size(581, 20);
            this.OutputDir.TabIndex = 3;
            this.OutputDir.Leave += new System.EventHandler(this.OutputDir_Leave);
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
            this.SearchLanguage.Size = new System.Drawing.Size(69, 20);
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
            this.ComboLanguage.Location = new System.Drawing.Point(414, 107);
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
            this.comboTrack.Location = new System.Drawing.Point(627, 107);
            this.comboTrack.Name = "comboTrack";
            this.comboTrack.Size = new System.Drawing.Size(56, 21);
            this.comboTrack.TabIndex = 13;
            // 
            // SearchTrack
            // 
            this.SearchTrack.Location = new System.Drawing.Point(552, 107);
            this.SearchTrack.Name = "SearchTrack";
            this.SearchTrack.Size = new System.Drawing.Size(69, 20);
            this.SearchTrack.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 110);
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
            this.buttonPrecheck.Size = new System.Drawing.Size(330, 23);
            this.buttonPrecheck.TabIndex = 15;
            this.buttonPrecheck.Text = "PreCheck";
            this.buttonPrecheck.UseVisualStyleBackColor = true;
            this.buttonPrecheck.Click += new System.EventHandler(this.buttonPrecheck_Click);
            // 
            // buttonRemux
            // 
            this.buttonRemux.Enabled = false;
            this.buttonRemux.Location = new System.Drawing.Point(353, 267);
            this.buttonRemux.Name = "buttonRemux";
            this.buttonRemux.Size = new System.Drawing.Size(330, 23);
            this.buttonRemux.TabIndex = 16;
            this.buttonRemux.Text = "Remux";
            this.buttonRemux.UseVisualStyleBackColor = true;
            this.buttonRemux.Click += new System.EventHandler(this.buttonRemux_Click);
            // 
            // TrackListRemux
            // 
            this.TrackListRemux.FormattingEnabled = true;
            this.TrackListRemux.Location = new System.Drawing.Point(353, 140);
            this.TrackListRemux.Name = "TrackListRemux";
            this.TrackListRemux.Size = new System.Drawing.Size(330, 121);
            this.TrackListRemux.TabIndex = 20;
            // 
            // TrackList
            // 
            this.TrackList.FormattingEnabled = true;
            this.TrackList.Location = new System.Drawing.Point(12, 140);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(330, 121);
            this.TrackList.TabIndex = 19;
            // 
            // bMkvToolNix
            // 
            this.bMkvToolNix.Location = new System.Drawing.Point(608, 12);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 305);
            this.Controls.Add(this.comboSearchName);
            this.Controls.Add(this.bMkvToolNix);
            this.Controls.Add(this.TrackListRemux);
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
            this.Controls.Add(this.OutputDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputDir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mkv Remux";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputDir;
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
        private System.Windows.Forms.ListBox TrackListRemux;
        private System.Windows.Forms.ListBox TrackList;
        private System.Windows.Forms.Button bMkvToolNix;
        private System.Windows.Forms.FolderBrowserDialog fbdMkvToolNix;
        private System.Windows.Forms.ComboBox comboSearchName;
    }
}

