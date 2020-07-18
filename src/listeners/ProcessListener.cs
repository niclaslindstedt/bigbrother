using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BigBrother.Core
{
	public class ProcessListener : Command
	{
		private List<string> Processes => Process.GetProcesses().Select(p => p.ProcessName).ToList();
		private string CurrentProcess => Process.GetCurrentProcess().ProcessName;

		public void Run(State state)
		{

		}
	}
}
