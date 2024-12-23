using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern.Services.Singleton
{
    public class ConfigurationManagerSingletonExample
    {
        private static readonly Lazy<ConfigurationManagerSingletonExample> _instance =
            new Lazy<ConfigurationManagerSingletonExample>(() => new ConfigurationManagerSingletonExample());

        private readonly Dictionary<string, string> _settings;

        private ConfigurationManagerSingletonExample()
        {
            _settings = new Dictionary<string, string>
        {
            { "AppTitle", "My Application" },
            { "Version", "1.0.0" }
        };
        }

        public static ConfigurationManagerSingletonExample Instance => _instance.Value;

        public string GetSetting(string key)
        {
            return _settings.TryGetValue(key, out var value) ? value : "Key not found";
        }
    }
}

