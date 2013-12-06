using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace InpOut32.CSharp.Net
{
  public class Config
  {
    public int Port { get; set; }
    public String LogName { get; set; }
    public int TimeoutInMilliseconds { get; set; }

    private Config() 
    {
      Port = 0x379;
      LogName = "log.txt";
      TimeoutInMilliseconds = 1000;
    }

    private static String FilePath
    {
      get
      {
        return "Config.xml";
      }
    }
    public void Save()
    {
      using (var fs = new FileStream(FilePath, FileMode.OpenOrCreate))
      {
        var xmlSerializer = new XmlSerializer(typeof(Config));

        xmlSerializer.Serialize(fs, this);

        fs.Flush();
        fs.Close();
      }
    }

    public static Config Load()
    {
      if (!File.Exists(FilePath))
        return new Config();
      using (var fs = new FileStream(FilePath, FileMode.Open))
      {
        var xmlSerializer = new XmlSerializer(typeof(Config));

        var cfg = xmlSerializer.Deserialize(fs) as Config;

        fs.Close();
        return cfg;
      }
    }
  }
}
