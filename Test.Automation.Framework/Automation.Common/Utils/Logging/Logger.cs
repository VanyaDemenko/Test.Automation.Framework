using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace Automation.Common.Utils.Logging
{
    public static class Logger
    {
        public static void SetUp()
        {
            var loggingLevelSwitch = new LoggingLevelSwitch(LogEventLevel.Verbose);

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(loggingLevelSwitch)
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}
