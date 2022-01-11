using MKVSubFixer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKVSubFixer
{
    public partial class Form1 : Form
    {
        Models.Videos remuxVideo = new Models.Videos();
        List<Models.Videos> remuxList = new List<Models.Videos>();
        List<Models.Videos> videoList = new List<Models.Videos>();
        string mkvmergePath = Settings.Default.MkvToolNixPath;

        public Form1()
        {
            InitializeComponent();
        }                

        private void buttonPrecheck_Click(object sender, EventArgs e)
        {
            PreCheck();
        }       

        private void buttonRemux_Click(object sender, EventArgs e)
        {
            Remux();
        }        

        private void CheckSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSearch.Checked)
            {
                SearchText.Enabled = true;
                comboSearchName.Enabled = true;
            }
            else
            {
                SearchText.Enabled = false;
                comboSearchName.Enabled = false;
            }
        }

        private void bMkvToolNix_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Settings.Default.MkvToolNixPath))
            {
                fbdMkvToolNix.SelectedPath = Settings.Default.MkvToolNixPath;
            }
            else
            {
                fbdMkvToolNix.SelectedPath = Settings.Default.LastFolder;
            }

            if (fbdMkvToolNix.ShowDialog() == DialogResult.OK)
            {                
                Settings.Default.LastFolder = fbdMkvToolNix.SelectedPath;
                Settings.Default.MkvToolNixPath = fbdMkvToolNix.SelectedPath;
                if (!Settings.Default.MkvToolNixPath.EndsWith("\\"))
                {
                    Settings.Default.MkvToolNixPath += "\\";
                }
                Settings.Default.Save();
            }
        }

        private void OutputDir_Leave(object sender, EventArgs e)
        {
            if (tbOutputDir.Text != "")
            {
                buttonRemux.Enabled = true;
            }
            else
            {
                buttonRemux.Enabled = false;
            }
        }

        private void InputDir_Leave(object sender, EventArgs e)
        {
            if (tbInputDir.Text != "" && Directory.Exists(tbInputDir.Text))
            {                
                buttonPrecheck.Enabled = true;
            }
            else
            {
                buttonPrecheck.Enabled = false;
            }
        }

        private void PreCheck()
        {
            TrackInfo trackInfo = new TrackInfo();
            remuxList.Clear();
            remuxVideo = new Models.Videos();
            TrackList.Items.Clear();
            TrackListRemux.Items.Clear();
            string inputDir = tbInputDir.Text;
            if (!inputDir.EndsWith("\\"))
            {
                tbInputDir.Text += "\\";
                inputDir += "\\";
            }
            string search = SearchText.Text.ToLower();
            string searchLanguage = SearchLanguage.Text.ToLower();
            string searchTrack = SearchTrack.Text.ToLower();

            int newTrackNumber = 0;
            int oldTrackNumber = 0;
            bool trackSwap = false;
            if (tbNewTrackNum.Text.Trim() != "" && SearchTrack.Text.Trim() != "")
            {
                try
                {
                    newTrackNumber = Int32.Parse(tbNewTrackNum.Text);
                    oldTrackNumber = Int32.Parse(SearchTrack.Text);
                    trackSwap = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("A Track Number is not a Number. {0}", ex.Message);
                }
            }

            Models.Videos videoInfo = new Models.Videos();
            
            Models.Tracks remuxTracks = new Models.Tracks();
            List<Models.Tracks> remuxTrackList = new List<Models.Tracks>();
            string[] inputFileList = { };
            if (Settings.Default.IncludeSubDir)
            {
                inputFileList = Directory.GetFiles(inputDir, "*.mkv", SearchOption.AllDirectories);
            }
            else
            {
                inputFileList = Directory.GetFiles(inputDir, "*.mkv");
            }
            object[] workArgs = { inputFileList };
            backgroundWorker1.RunWorkerAsync(workArgs);
            /*foreach (string f in inputFileList)
            {
                //videoInfo = trackInfo.GetTrackInfo(f);
                
                //videoList.Add(videoInfo);
            }*/
            foreach (Models.Videos v in videoList)
            {
                remuxTrackList = new List<Models.Tracks>();
                /*TrackList.Items.Add(v.Name);
                foreach (Models.Tracks t in v.TrackList)
                {
                    if (t.Type == "subtitles")
                    {
                        TrackList.Items.Add(t.Id + "||" + t.Type + "||" + t.Language + "||" + t.Name + "||" + t.Codec);
                    }
                }*/
                //TrackListRemux.Items.Add(v.Name);
                foreach (Models.Tracks t in v.TrackList)
                {
                    if (t.Type == "subtitles")
                    {
                        if (CheckSearch.Checked == true && comboSearchName.Text != "")
                        {
                            if ((search == null) && (t.Name == null))
                            {
                                t.Language = comboSearchName.Text;
                            }
                            else if (t.Name == null)
                            {
                                t.Language = comboSearchName.Text;
                            }
                            else if (t.Name.ToLower().Contains(search))
                            {
                                t.Language = comboSearchName.Text;
                            }
                        }
                        if (searchLanguage != "")
                        {
                            if (t.Language.ToLower().Contains(searchLanguage))
                            {
                                t.Language = ComboLanguage.Text;
                                if (t.Name == null)
                                {
                                    t.Name = ComboLanguage.Text;
                                }
                            }
                        }
                        if (searchTrack != "")
                        {
                            if (t.Id.ToLower().Contains(searchTrack))
                            {
                                t.Language = comboTrack.Text;
                                if (t.Name == null)
                                {
                                    t.Name = comboTrack.Text;
                                }
                            }
                        }
                        if (trackSwap)
                        {
                            if (Int32.Parse(t.Id) == oldTrackNumber)
                            {
                                t.Id = newTrackNumber.ToString();
                            }
                            else if (Int32.Parse(t.Id) == newTrackNumber)
                            {
                                t.Id = oldTrackNumber.ToString();
                            }
                        }
                        //TrackListRemux.Items.Add(t.Id + " || " + t.Type + "||" + t.Language + "||" + t.Name + "||" + t.Codec);
                    }
                    remuxTracks.Id = t.Id;
                    remuxTracks.Type = t.Type;
                    remuxTracks.Language = t.Language;
                    remuxTracks.Name = t.Name;
                    remuxTracks.Codec = t.Codec;
                    remuxTrackList.Add(remuxTracks);
                    remuxTracks = new Models.Tracks();
                }                
                remuxVideo.Name = v.Name;
                remuxVideo.TrackList = remuxTrackList.OrderBy(x => x.Id).ToList();
                remuxList.Add(remuxVideo);
                remuxVideo = new Models.Videos();                
            }
            foreach (Models.Videos v in remuxList)
            {
                TrackListRemux.Items.Add(v.Name);
                foreach (Models.Tracks t in v.TrackList)
                {
                    if (t.Type == "subtitles")
                    {
                        TrackListRemux.Items.Add(t.Id + " || " + t.Type + "||" + t.Language + "||" + t.Name + "||" + t.Codec);

                    }
                }
            }
        }
        private void Remux()
        {
            string cmdLine = "";
            string fullCmdLine = "";
            string outputPath = tbOutputDir.Text;
            List<string> remuxListBatch = new List<string>();
            
            if (!outputPath.EndsWith("\\"))
            {
                tbOutputDir.Text += "\\";
                outputPath += "\\";
            }
            if (outputPath != "")
            {
                Directory.CreateDirectory(outputPath);
            }
            string inputPath = tbInputDir.Text;
            if (!inputPath.EndsWith("\\"))
            {
                tbInputDir.Text += "\\";
                inputPath += "\\";
            }
            foreach (Models.Videos v in remuxList)
            {
                int trackCount = v.TrackList.Count();

                string singleCmdLine = "";

                cmdLine += "\"C:\\Program Files\\MKVToolNix\\mkvmerge.exe\" -o \"" + outputPath + v.Name + "\"";
                singleCmdLine += "\"C:\\Program Files\\MKVToolNix\\mkvmerge.exe\" -o \"" + outputPath + v.Name + "\"";
                foreach (Models.Tracks t in v.TrackList)
                {
                    cmdLine += " --language " + (Int32.Parse(t.Id) - 1) + ":" + t.Language;
                    singleCmdLine += " --language " + (Int32.Parse(t.Id) - 1) + ":" + t.Language;
                    cmdLine += " --track-name " + (Int32.Parse(t.Id) - 1) + ":\"" + t.Name + "\"";
                    singleCmdLine += " --track-name " + (Int32.Parse(t.Id) - 1) + ":\"" + t.Name + "\"";
                }
                cmdLine += " \"(\" \"" + inputPath + v.Name + "\" \")\"";
                singleCmdLine += " \"(\" \"" + inputPath + v.Name + "\" \")\"";
                cmdLine += " --track-order ";
                singleCmdLine += " --track-order ";
                int count = 1;
                foreach (Models.Tracks t in v.TrackList)
                {
                    cmdLine += "0:" + (Int32.Parse(t.Id) - 1);
                    singleCmdLine += "0:" + (Int32.Parse(t.Id) - 1);
                    if (count != v.TrackList.Count)
                    {
                        cmdLine += ",";
                        singleCmdLine += ",";
                    }
                    count++;
                }                
                cmdLine += "\"";
                singleCmdLine += "\"";
                remuxListBatch.Add(singleCmdLine);
                cmdLine += "\r\n\r\n\n";

            }
            using (System.IO.StreamWriter batchFile = new System.IO.StreamWriter(Path.Combine(outputPath, "Batch.bat"), true))
            {
                batchFile.WriteLine(cmdLine);
            }
        }

        private void butInputDir_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbInputDir.Text))
            {
                fbdInputDir.SelectedPath = tbInputDir.Text;
            }
            else
            {
                fbdInputDir.SelectedPath = Settings.Default.LastFolder;
            }

            if (fbdInputDir.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.LastFolder = fbdInputDir.SelectedPath;
                tbInputDir.Text = fbdInputDir.SelectedPath;
                if (!tbInputDir.Text.EndsWith("\\"))
                {
                    tbInputDir.Text += "\\";
                }
                if (Directory.Exists(tbInputDir.Text))
                {
                    buttonPrecheck.Enabled = true;
                }
                Settings.Default.Save();
            }
        }

        private void butOutputDir_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbOutputDir.Text))
            {
                fbdOutputDir.SelectedPath = tbOutputDir.Text;
            }
            else
            {
                fbdOutputDir.SelectedPath = Settings.Default.LastFolder;
            }

            if (fbdOutputDir.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.LastFolder = fbdOutputDir.SelectedPath;
                tbOutputDir.Text = fbdOutputDir.SelectedPath;
                if (!tbOutputDir.Text.EndsWith("\\"))
                {
                    tbOutputDir.Text += "\\";
                }
                if (Directory.Exists(tbOutputDir.Text))
                {
                    buttonRemux.Enabled = true;
                }
                Settings.Default.Save();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            TrackInfo trackInfo = new TrackInfo();
            object[] arg = e.Argument as object[];
            string[] input = (string[])arg[0];
            Models.Videos videoInfo = new Models.Videos();
            foreach (string f in input)
            {
                videoInfo = trackInfo.GetTrackInfo(f);
                videoList.Add(videoInfo);
                Invoke(new Action(() =>
                {
                    TrackList.Items.Add(videoInfo.Name);
                }));
                foreach (Models.Tracks t in videoInfo.TrackList)
                {
                    if (t.Type == "subtitles")
                    {
                        Invoke(new Action(() =>
                        {
                            TrackList.Items.Add(t.Id + "||" + t.Type + "||" + t.Language + "||" + t.Name + "||" + t.Codec);
                        }));
                    }
                }
            }
            
        }

        private void checkSubDir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSubDir.Checked == true)
            {
                Settings.Default.IncludeSubDir = true;
            }
            else
            {
                Settings.Default.IncludeSubDir = false;

            }
            Settings.Default.Save();
        }
    }
}
