using BigBrother.Core;
using Xunit;

namespace BigBrother.Tests
{
    public class GetProcessesTests
    {
        [Fact]
        public void GetProcesses_ReturnsNonEmptyList()
        {
            var pv = new ProcessViewer();

            var processes = pv.GetProcesses();

            Assert.NotEmpty(processes);
        }
        
        [Fact]
        public void GetCurrentProcess_ReturnsNonEmptyString()
        {
            var pv = new ProcessViewer();

            var process = pv.GetCurrentProcess();

            Assert.NotNull(process);
        }
    }
}
