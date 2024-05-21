using Microsoft.Extensions.Configuration;

namespace Automation.Common.Utils.EnvironmentManager
{
    public static class EnvironmentManager
    {
        private static readonly string _pathToSettings = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings");

        private static readonly object _lockObj = new();
        private static readonly object _lockObj2 = new();

        public static TestEnvironment CurrentEnvironment { get; private set; } = null!;

        public static void LoadSettings(string environmentName)
        {
            if (CurrentEnvironment == null)
            {
                lock (_lockObj)
                {
                    CurrentEnvironment = GetEnvironmentObject(environmentName);
                }
            }
        }

        public static string GetLocal()
        {
            lock (_lockObj2)
            {
                var builder = GetConfiruration();
                var currentEnv = builder.GetSection("LOCAL").Get<string>();
                return currentEnv;
            }
        }

        private static TestEnvironment GetEnvironmentObject(string environmentName)
        {
            var builder = GetConfiruration();
            var currentEnv = builder.GetSection(environmentName).Get<TestEnvironment>();

            return currentEnv ?? throw new NullReferenceException(nameof(currentEnv));
        }

        private static IConfiguration GetConfiruration()
        {
            const string settingsFileName = "environment.json";

            var builder = new ConfigurationBuilder()
                .SetBasePath(_pathToSettings)
                .AddJsonFile(settingsFileName)
                .AddEnvironmentVariables()
            .Build();

            return builder;
        }
    }
}
