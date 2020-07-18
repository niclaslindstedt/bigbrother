using System;

using BigBrother.Core;


namespace BigBrother.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
			var eventLoop = new EventLoop();

			eventLoop.Start();
		}
    }
}
