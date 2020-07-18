using System;
using System.Threading;

namespace BigBrother.Core
{
	public class EventLoop
	{
		private DateTime _lastEventTime;
		private readonly Command[] _commands;
		private State _state = new State();

		public EventLoop(params Command[] commands)
		{
			_commands = commands;
		}

		public void Start()
		{
			for (_lastEventTime = DateTime.Now; true; SleepUntilNextLoop()) {
				foreach (var command in _commands)
				{
					command.Run();
				}
			}
		}

		private void SleepUntilNextLoop()
		{
			Thread.Sleep(_lastEventTime.AddSeconds(1) - DateTime.Now);
			_lastEventTime = DateTime.Now;
		}
	}
}
