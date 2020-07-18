using System;

using BigBrother.Core;


namespace BigBrother.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
			var processViewer = new ProcessViewer();

			var processes = processViewer.GetProcesses();

			foreach (var process in processes) {
				Console.WriteLine(process);
			}
		}
    }
}
