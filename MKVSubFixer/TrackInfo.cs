using MKVSubFixer.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKVSubFixer
{
    class TrackInfo
    {
        public Models.Videos GetTrackInfo(string inputDir)
        {
            Models.Videos videoInfo = new Models.Videos();
            Models.Tracks tracks = new Models.Tracks();
            List<Models.Tracks> trackList = new List<Models.Tracks>();

            string filename = inputDir;

            string runfile = "\"" + Settings.Default.MkvToolNixPath + "mkvinfo.exe\" \"" + filename + "\"";

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
                                videoInfo.Name = filename;
                                break;
                            case "Track type":
                                tracks.Type = content;
                                break;
                            case "Codec ID":
                                tracks.Codec = content;
                                break;
                            case "Language":
                                tracks.Language = content;
                                break;
                            case "Name":
                                tracks.Name = content;
                                break;                            
                        }
                    }
                    else if (nextLine.Contains("Attachments") || nextLine.Contains("Tags") || nextLine.Contains("Cluster"))
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
    }
}
