using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MKVSubFixer
{
    public partial class CommandLine : Form
    {
        string runfile = "";
        int progressCount = 0;
        int progressDone = 0;
        bool keepBatch = false;

        public CommandLine(string file, int fileCount, bool keepBatchCb)
        {
            InitializeComponent();
            runfile = file;
            progressCount = fileCount;
            progressBar1.Value = 0;
            keepBatch = keepBatchCb;

            this.Show();
           
            backgroundWorker1.RunWorkerAsync();    
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int fileProgressStep = (int)Math.Ceiling(((double)100) / progressCount);

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
            while (progressDone != progressCount)
            {
                var nextLine = reader.ReadLine();
                Invoke(new Action(() => { textBox1.AppendText(nextLine + "\r\n\r\n"); }));
                if (nextLine.Contains("Progress: 100%"))
                {
                    backgroundWorker1.ReportProgress(fileProgressStep);
                    progressDone++;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Step = e.ProgressPercentage;
            progressBar1.PerformStep();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string[] finishedFiles = Directory.GetFiles(Path.GetDirectoryName(runfile), "*.mkv");
            if (!finishedFiles.Count().Equals(progressCount))
            {
                MessageBox.Show("There is a finished file discrepancy. Makes sure all files were remuxed before deleting the originals.");
            }
            if (!keepBatch)
            {
                if (File.Exists(runfile))
                {
                    File.Delete(runfile);
                }
            }
            okButton.Enabled = true;            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CommandLine.ActiveForm.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                progressDone = progressCount;
            }
        }
    }
}
