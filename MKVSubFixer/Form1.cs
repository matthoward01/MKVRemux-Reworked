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
            fbdMkvToolNix.SelectedPath = Settings.Default.LastFolder;  

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
            if (OutputDir.Text != "" && Directory.Exists(OutputDir.Text))
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
            if (InputDir.Text != "" && Directory.Exists(InputDir.Text))
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
            string inputDir = InputDir.Text;
            if (!inputDir.EndsWith("\\"))
            {
                InputDir.Text += "\\";
                inputDir += "\\";
            }
            string search = SearchText.Text.ToLower();
            string searchLanguage = SearchLanguage.Text.ToLower();
            string searchTrack = SearchTrack.Text.ToLower();

            Models.Videos videoInfo = new Models.Videos();
            List<Models.Videos> videoList = new List<Models.Videos>();
            Models.Tracks remuxTracks = new Models.Tracks();
            List<Models.Tracks> remuxTrackList = new List<Models.Tracks>();
            string[] inputFileList = Directory.GetFiles(inputDir, "*.mkv");
            foreach (string f in inputFileList)
            {
                videoInfo = trackInfo.GetTrackInfo(f);
                videoList.Add(videoInfo);
            }
            foreach (Models.Videos v in videoList)
            {
                remuxTrackList = new List<Models.Tracks>();
                TrackList.Items.Add(v.Name);
                foreach (Models.Tracks t in v.TrackList)
                {
                    if (t.Type == "subtitles")
                    {
                        TrackList.Items.Add(t.Id + "||" + t.Type + "||" + t.Language + "||" + t.Name + "||" + t.Codec);
                    }
                }
                TrackListRemux.Items.Add(v.Name);
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
                        TrackListRemux.Items.Add(t.Id + " || " + t.Type + "||" + t.Language + "||" + t.Name + "||" + t.Codec);
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
                remuxVideo.TrackList = remuxTrackList;
                remuxList.Add(remuxVideo);
                remuxVideo = new Models.Videos();
            }
        }
        private void Remux()
        {
            string cmdLine = "";
            string fullCmdLine = "";
            string outputPath = OutputDir.Text;
            if (!outputPath.EndsWith("\\"))
            {
                OutputDir.Text += "\\";
                outputPath += "\\";
            }
            if (outputPath != "")
            {
                Directory.CreateDirectory(outputPath);
            }
            string inputPath = InputDir.Text;
            if (!inputPath.EndsWith("\\"))
            {
                InputDir.Text += "\\";
                inputPath += "\\";
            }
            foreach (Models.Videos v in remuxList)
            {
                int trackCount = v.TrackList.Count();

                cmdLine += "\"C:\\Program Files\\MKVToolNix\\mkvmerge.exe\" -o \"" + outputPath + v.Name + "\"";
                foreach (Models.Tracks t in v.TrackList)
                {
                    cmdLine += " --language " + (Int32.Parse(t.Id) - 1) + ":" + t.Language;
                    cmdLine += " --track-name " + (Int32.Parse(t.Id) - 1) + ":\"" + t.Name + "\"";
                }
                cmdLine += " \"(\" \"" + inputPath + v.Name + "\" \")\"";
                cmdLine += " --track-order ";
                int count = 1;
                foreach (Models.Tracks t in v.TrackList)
                {
                    cmdLine += "0:" + (Int32.Parse(t.Id) - 1);
                    if (count != v.TrackList.Count)
                    {
                        cmdLine += ",";
                    }
                    count++;
                }
                cmdLine += "\"\r\n\r\n\n";

            }
            using (System.IO.StreamWriter batchFile = new System.IO.StreamWriter(Path.Combine(outputPath, "Batch.bat"), true))
            {
                batchFile.WriteLine(cmdLine);
            }
        }
    }
}
