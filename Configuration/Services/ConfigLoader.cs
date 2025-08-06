using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuration.Abstractions;
using Configuration.Configs;
using Configuration.Exceptions;
using Configuration.ValueObjects;

namespace Configuration.Services
{
    public static class ConfigLoader
    {
        public static Config Load(string environment = "development", string fileType = "json")
        {
            IConfig config = fileType switch
            {
                "json" => new JsonConfig(environment),
                "xml" => new XmlConfig(environment),
                _ => throw new NotSupportedException($"Unsupported config file type: {fileType}")
            };
            try
            {
                config.Open();
                Config result = config.Read();
                return result;
            } catch(Exception e)
            {
                Console.WriteLine(e);
                throw new ConfigurationLoadException("Failed to load configuration", e);
              
            } finally
            {
                config.Close();
            }
        }
    }
}



//namespace Configuration.Services
//{
//    public static class ConfigLoader
//    {
//        private static readonly string BASE_PATH = "./configs";
//        private static readonly string DEFAULT_ENVIRONMENT = "development";
//        private static readonly string DEFAULT_FILE_TYPE = "json";
//        public static Config Load(string environment, string fileType)
//        {
//            StringBuilder path = new StringBuilder();
//            path.Append(BASE_PATH);
//            if (environment == null)
//            {
//                path.Append($"/{DEFAULT_ENVIRONMENT}");
//            }
//            else
//            {
//                path.Append($"/{environment}");
//            }
//            if (fileType == null)
//            {
//                path.Append($"/config.{DEFAULT_FILE_TYPE}");
//            }
//            else
//            {
//                path.Append($"/config.{fileType}");
//            }
//            string configPath = path.ToString();
//            return null;
//        }
//    }
//}