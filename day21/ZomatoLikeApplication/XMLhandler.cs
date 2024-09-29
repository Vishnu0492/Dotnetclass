using System.Xml.Linq;

namespace ZomatoLikeApplication
{
    public class XMLhandler
    {
       
            public static void ParseXml(string filePath)
            {
                XElement xml = XElement.Load(filePath);
                foreach (var restaurant in xml.Elements("restaurant"))
                {
                    string name = restaurant.Element("name").Value;
                    string address = restaurant.Element("address").Value;
                    string rating = restaurant.Element("rating").Value;
                    Console.WriteLine($"Restaurant: {name}, Address: {address}, Rating: {rating}");
                }
           }
        }
    }

