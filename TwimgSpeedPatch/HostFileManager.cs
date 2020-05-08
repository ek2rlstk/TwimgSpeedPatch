using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SimpleJSON;

namespace TwimgSpeedPatch
{
    public static class HostFileManager
    {
        private static readonly string HostFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts");

        public static void Init()
        {
            
        }

        public static Process Patch()
        {
            var ps = new ProcessStartInfo(Application.StartupPath + @"\TwMediaCdnPatch.exe");
            ps.CreateNoWindow = true;
            ps.UseShellExecute = false;
            ps.RedirectStandardError = true;
            ps.RedirectStandardOutput = true;
            return Process.Start(ps);
        }

        public static void OpenHostFile()
        {
            Process.Start("notepad.exe", HostFileName);
        }
    }
}
