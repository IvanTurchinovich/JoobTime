using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JoobTime
{
    class xlsx_
    {
        public static string read_xlsx(string param)
        {
            string value;
            using (XmlReader xml_reader = XmlReader.Create(Application.StartupPath + @"\settings_joob_time.xml"))
            {
                try
                {
                    XmlDocument d = new XmlDocument();
                    d.Load(xml_reader);
                    value = d.GetElementsByTagName(string.Format("{0}", param)).Item(0).InnerText;
                    return value;
                }
                catch
                {
                    MessageBox.Show("error xml_");
                    return null;
                }
                finally
                {
                    xml_reader.Close();
                }
            }
        }

        public static void write_xml(string param,string value)
        {

            using (XmlReader xml_reader = XmlReader.Create(Application.StartupPath + @"\settings_joob_time.xml"))
            {
                try
                {
                    XmlDocument d = new XmlDocument();
                    d.Load(xml_reader);
                    xml_reader.Close();
                    d.GetElementsByTagName(string.Format("{0}", param)).Item(0).InnerText = value;
                    d.Save(Application.StartupPath + @"\settings_joob_time.xml");
                }
                catch
                {
                    MessageBox.Show("error xml_");
                }
                finally
                {
                    xml_reader.Close();
                }
            }
        }
    }
}
