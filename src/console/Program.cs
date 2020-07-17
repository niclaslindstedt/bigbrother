using System;

using BigBrother.Core;


namespace BigBrother.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
			var processViewer = new ProcessViewer();

			Console.WriteLine(processViewer.GetCurrentProcess());
		}
    }
}
