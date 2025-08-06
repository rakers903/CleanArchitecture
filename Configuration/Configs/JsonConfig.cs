using Configuration.Abstractions;
using Configuration.Constants;
using Configuration.Exceptions;
using Configuration.ValueObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Configs
{
    public class JsonConfig: IConfig
    {
        private string _environment;
        private StreamReader? _file;
        public JsonConfig(string? environment)
        {
            if (environment == null)
            {
                environment = ConfigConstants.DEFAULT_ENVIRONMENT;
            }
            _environment = environment; 
        }

        public void Close()
        {
            try
            {
                if(_file != null)
                {
                    _file.Close();
                }
            } catch(Exception e)
            {
                throw e;
            }
        }

        public void Open()
        {
            string configPath = $"{ConfigConstants.BASE_PATH}/{_environment}_config.json";
            try
            {
                _file = File.OpenText(configPath);
            } catch(Exception e)
            {
                throw e;
            }
        }

        public Config Read()
        {
            try
            {
                if(_file != null)
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Config? config = serializer.Deserialize(_file, typeof(Config)) as Config;
                    if (config == null)
                    {
                        throw new ConfigurationLoadException("Could not read file", null);
                    }
                    return config;
                }
                throw new ConfigurationLoadException("Could not read file", null);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
