using Configuration.Abstractions;
using Configuration.Constants;
using Configuration.Exceptions;
using Configuration.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Configuration.Configs
{
    public class XmlConfig: IConfig
    {
        private string _environment;
        private FileStream? _file;
        public XmlConfig(string? environment)
        {
            if(environment == null)
            {
                environment = ConfigConstants.DEFAULT_ENVIRONMENT;
            }
            _environment = environment;
        }

        public void Close()
        {
            try
            {
                if (_file != null)
                {
                    _file.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Open()
        {
            string configPath = $"{ConfigConstants.BASE_PATH}/{_environment}_config.xml";
            try
            {
                _file = File.OpenRead(configPath);
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
                    XmlSerializer serializer =
                        new XmlSerializer(typeof(Config));
                    Config? config = serializer.Deserialize(_file) as Config;
                    if (config == null)
                    {
                        throw new ConfigurationLoadException("Could not read file", null);
                    }
                    return config;
                }
                throw new ConfigurationLoadException("Could not read file", null);
            } catch(Exception e)
            {
                throw e;
            }
        }
    }
}
