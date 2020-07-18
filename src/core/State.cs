using System;

namespace BigBrother.Core
{
	public class State
	{
		public int MouseClicks { get; set; } = 0;
		public DateTime StartTime { get; set; } = DateTime.Now;
		public TimeSpan InactiveTime { get; set; } = TimeSpan.FromSeconds(0);
	}
}
