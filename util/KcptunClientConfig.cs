using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace util
{
    public class KcptunClientConfig
    {
        public string ServerAddress { get; set; }

        public string ServerPort { get; set; }

        public string LocalPort { get; set; }

        public string Key { get; set; }

        public void Save(string fileName)
        {
            using (FileStream file = File.Create(fileName))
            {
                XmlSerializer writer = new XmlSerializer(typeof(KcptunClientConfig));
                writer.Serialize(file, this);
            }
        }

        public static string DefaultFileName
        {
            get { return Path.Combine(Directory.GetCurrentDirectory(), "util_cfg.xml"); }
        }

        internal static KcptunClientConfig LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return null;
            }

            using (FileStream file = File.OpenRead(fileName))
            {
                XmlSerializer reader = new XmlSerializer(typeof(KcptunClientConfig));
                return (KcptunClientConfig)reader.Deserialize(file);
            }
        }
    }
}
