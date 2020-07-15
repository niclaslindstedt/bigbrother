using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BigBrother.Core
{
    public class ProcessViewer
    {
        public List<string> GetProcesses()
        {
            var processes = Process
                .GetProcesses()
                .Select(p => p.ProcessName)
                .ToList();

            return processes;
        }

        public string GetCurrentProcess()
        {
            return Process.GetCurrentProcess().ProcessName;
        }
    }
}
