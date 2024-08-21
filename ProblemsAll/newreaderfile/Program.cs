using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day_13
{
    internal class newReadxml
    {
        public static void Main()
        {
            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Administrator\\source\\repos\\newreaderfile\\Employeedata.xml", null);
            XmlTextReader reader = new XmlTextReader("C:\\Users\\Administrator\\source\\repos\\newreaderfile\\bookdata.xml");
            XmlDocument xmlDoc = new XmlDocument();
            string filename = "C:\\Users\\Level Up Solutions 1\\Desktop\\course-structure\\labs\\Day-13\\Day-13\\xmlfiles\\books.xml";
            xmlDoc.Load(filename);
            xmlDoc.Save(Console.Out);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    writer.WriteNode(reader, true);
                }
            }
            XmlNode root =xmlDoc.DocumentElement;
            root.RemoveAll();
            XmlElement rootnode = xmlDoc.DocumentElement;
            rootnode.ReplaceChild(<fragment>, rootnode.LastChild());
            writer.Close();
        }
    }
}