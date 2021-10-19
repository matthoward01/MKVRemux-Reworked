
namespace MKVAudioFixer
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SearchTrack = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TrackListRemux = new System.Windows.Forms.ListBox();
            this.TrackList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Directory";
            // 
            // InputDir
            // 
            this.InputDir.Location = new System.Drawing.Point(102, 12);
            this.InputDir.Name = "InputDir";
            this.InputDir.Size = new System.Drawing.Size(581, 20);
            this.InputDir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Directory";
            // 
            // OutputDir
            // 
            this.OutputDir.Location = new System.Drawing.Point(102, 43);
            this.OutputDir.Name = "OutputDir";
            this.OutputDir.Size = new System.Drawing.Size(581, 20);
            this.OutputDir.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Name";
            // 
            // CheckSearch
            // 
            this.CheckSearch.AutoSize = true;
            this.CheckSearch.Location = new System.Drawing.Point(13, 79);
            this.CheckSearch.Name = "CheckSearch";
            this.CheckSearch.Size = new System.Drawing.Size(15, 14);
            this.CheckSearch.TabIndex = 6;
            this.CheckSearch.UseVisualStyleBackColor = true;
            this.CheckSearch.CheckedChanged += new System.EventHandler(this.CheckSearch_CheckedChanged);
            // 
            // SearchText
            // 
            this.SearchText.Enabled = false;
            this.SearchText.Location = new System.Drawing.Point(103, 76);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(113, 20);
            this.SearchText.TabIndex = 7;
            // 
            // SearchLanguage
            // 
            this.SearchLanguage.Location = new System.Drawing.Point(317, 76);
            this.SearchLanguage.Name = "SearchLanguage";
            this.SearchLanguage.Size = new System.Drawing.Size(69, 20);
            this.SearchLanguage.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 79);
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
            this.ComboLanguage.Location = new System.Drawing.Point(392, 76);
            this.ComboLanguage.Name = "ComboLanguage";
            this.ComboLanguage.Size = new System.Drawing.Size(56, 21);
            this.ComboLanguage.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "eng",
            "jpn"});
            this.comboBox2.Location = new System.Drawing.Point(627, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(56, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // SearchTrack
            // 
            this.SearchTrack.Location = new System.Drawing.Point(552, 76);
            this.SearchTrack.Name = "SearchTrack";
            this.SearchTrack.Size = new System.Drawing.Size(69, 20);
            this.SearchTrack.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search Track";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "PreCheck";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remux";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TrackListRemux
            // 
            this.TrackListRemux.FormattingEnabled = true;
            this.TrackListRemux.Location = new System.Drawing.Point(353, 109);
            this.TrackListRemux.Name = "TrackListRemux";
            this.TrackListRemux.Size = new System.Drawing.Size(330, 121);
            this.TrackListRemux.TabIndex = 20;
            // 
            // TrackList
            // 
            this.TrackList.FormattingEnabled = true;
            this.TrackList.Location = new System.Drawing.Point(12, 109);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(330, 121);
            this.TrackList.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 279);
            this.Controls.Add(this.TrackListRemux);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox SearchTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox TrackListRemux;
        private System.Windows.Forms.ListBox TrackList;
    }
}

