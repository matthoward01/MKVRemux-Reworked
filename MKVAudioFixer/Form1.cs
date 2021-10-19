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

namespace MKVAudioFixer
{
    public partial class Form1 : Form
    {
        Models.Videos remuxVideo = new Models.Videos();
        List<Models.Videos> remuxList = new List<Models.Videos>();
        string mkvmergePath = @"C:\Program Files\MKVToolNix\";

        public Form1()
        {
            InitializeComponent();
        }

        private Models.Videos GetTrackInfo(string inputDir)
        {
            Models.Videos videoInfo = new Models.Videos();
            //List<Models.Videos> videoList = new List<Models.Videos>();
            Models.Tracks tracks = new Models.Tracks();
            List<Models.Tracks> trackList = new List<Models.Tracks>();

            string filename = inputDir;
            //string filename = @"H:\[Judas] Bleach 112-139 [BD 1080p][HEVC x265 10bit][Dual-Audio][Eng-Subs]\[Judas] Bleach - 113.mkv";

            string runfile = "\"" + mkvmergePath + "mkvinfo.exe\" \"" + filename + "\"";

            var startinfo = new ProcessStartInfo("cmd")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                FileName = runfile,
            };

            var process = new Process { StartInfo = startinfo };
            process.Start();
            var reader = process.StandardOutput;

            bool processFile = true;
            while (processFile == true)
            {
                var nextLine = reader.ReadLine();
                if (nextLine != null)
                {
                    int indexOfPlus = nextLine.IndexOf('+');
                    int indexOfColon = nextLine.IndexOf(':');
                    if (indexOfPlus > -1 && indexOfColon > indexOfPlus && nextLine.Length > indexOfColon + 2)
                    {
                        string key = nextLine.Substring(indexOfPlus + 2, indexOfColon - (indexOfPlus + 2));
                        string content = nextLine.Substring(indexOfColon + 2);

                        switch (key)
                        {
                            case "Track number":

                                if (tracks.Id != null)
                                {
                                    if (tracks.Language == null)
                                    {
                                        tracks.Language = "eng";
                                    }
                                    videoInfo.TrackList.Add(tracks);
                                    tracks = new Models.Tracks();

                                }
                                tracks.Id = ExtractTrackNumbers(content);
                                videoInfo.Name = Path.GetFileName(filename);
                                //tracks.Id = Convert.ToInt32(content);
                                break;
                            case "Track type":
                                tracks.Type = content;
                                break;
                            case "Codec ID":
                                tracks.Codec = content;
                                break;
                            //case "Language":
                            case "Language":
                                tracks.Language = content;
                                break;
                            case "Name":
                                tracks.Name = content;
                                break;
                        }
                    }
                    else if (nextLine.Contains("Cluster"))
                    {
                        if (tracks.Language == null)
                        {
                            tracks.Language = "eng";
                        }
                        videoInfo.TrackList.Add(tracks);
                        tracks = new Models.Tracks();
                        processFile = false;
                    }
                }
            }

            return videoInfo;
        }
        private string ExtractTrackNumbers(string content)
        {
            Int32 indexOfOpenParen = content.IndexOf('(');
            Int32 indexOfColon = content.LastIndexOf(':');
            Int32 indexOfCloseParen = content.LastIndexOf(')');
            string trackNum = "";
            if (indexOfOpenParen > 1 && indexOfColon > indexOfOpenParen + 1 && indexOfCloseParen > indexOfColon + 1)
            {
                trackNum = content.Substring(0, indexOfOpenParen - 1);
                string mkvToolsTrackNum = content.Substring(indexOfColon + 2, indexOfCloseParen - (indexOfColon + 2));

            }
            return trackNum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                videoInfo = GetTrackInfo(f);
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
                        if (CheckSearch.Checked == true)
                        {
                            if ((search == null) && (t.Name == null))
                            {
                                t.Language = "jpn";
                            }
                            else if (t.Name == null)
                            {
                                t.Language = "jpn";
                            }
                            else if (t.Name.ToLower().Contains(search))
                            {
                                t.Language = "jpn";
                            }
                        }
                        if (searchLanguage != "")
                        {
                            if (t.Language.ToLower().Contains(searchLanguage))
                            {
                                t.Language = ComboLanguage.Text;
                                t.Name = ComboLanguage.Text;
                            }
                        }
                        if (searchTrack != "")
                        {
                            if (t.Id.ToLower().Contains(searchTrack))
                            {
                                t.Language = ComboLanguage.Text;
                                t.Name = ComboLanguage.Text;
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

        private void button2_Click(object sender, EventArgs e)
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

        private void CheckSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSearch.Checked)
            {
                SearchText.Enabled = true;
            }
            else
            {
                SearchText.Enabled = false;
            }
        }
    }
}
