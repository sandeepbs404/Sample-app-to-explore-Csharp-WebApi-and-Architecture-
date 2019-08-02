using System.Configuration;

namespace CustomeConfiguration
{
    public class AppConfig : IConfig
    {
        public string Get(string key)
        {
            return ConfigurationManager.AppSettings.Get(key);
        }
    }
}
