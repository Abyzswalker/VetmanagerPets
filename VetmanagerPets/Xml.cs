using System.IO;
using System.Xml.Serialization;

namespace VetmanagerPets
{
    internal class Xml
    {
        private const string FileName = "//Config.xml";
        private string dir = Directory.GetCurrentDirectory();

        public bool WriteXML(VMSettingsModel configModel)
        {
           try
            {
                if (Directory.Exists(dir))
                {
                    var writer = new XmlSerializer(typeof(VMSettingsModel));

                    FileStream file = File.Create(dir + FileName);

                    writer.Serialize(file, configModel);
                    file.Close();                    
                }

                return true;
            }
            catch { return false; }
        }

        public VMSettingsModel ReadXML()
        {
            if (IsAvailableFile())
            {
                XmlSerializer reader = new XmlSerializer(typeof(VMSettingsModel));

                StreamReader file = new StreamReader(dir + FileName);
                VMSettingsModel vmSettingsModel = (VMSettingsModel) reader.Deserialize(file);
                file.Close();

                return vmSettingsModel;
            } else { return null; }
        }

        private bool IsAvailableFile()
        {
            bool fileExist = File.Exists(dir + FileName);

            if (fileExist)
                return true;
            else return false;            
        }
    }
}
