using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjectTdd
{
    public class LaunchProgram
    {
        public string Launching(string p)
        {
            var process = Process.Start(p);
            return process != null ? process.ProcessName : null;
        }
    }
}
