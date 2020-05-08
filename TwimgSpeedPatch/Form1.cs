using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TwimgSpeedPatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PatchButton_Click(object sender, EventArgs e)
        {
            Process pps = HostFileManager.Patch();
            pps.BeginOutputReadLine();
            pps.BeginErrorReadLine();
            pps.OutputDataReceived += (object send, DataReceivedEventArgs ee) => status.AppendText(ee.Data + Environment.NewLine);
            pps.ErrorDataReceived += (object send, DataReceivedEventArgs ee) => status.AppendText(ee.Data + Environment.NewLine);
            pps.WaitForExit();
        }


        private void OpenHostFile_Click(object sender, EventArgs e)
        {
            HostFileManager.OpenHostFile();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/sokcuri");
        }

        private void LinkLabel2_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/ek2rlstk");
        }
    }
}
