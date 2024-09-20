using System;
using System.Linq;
using System.Xml.Linq;

namespace Xmalfile_product
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDoc = XDocument.Load("product.xml");

            //Add new element
            XElement newProduct = new XElement("Product",

                                  new XElement("ID", 4),
                                  new XElement("Name","Smartwatch"),
                                  new XElement("Price", 250),
                                  new XElement("Stock", 15)
                ) ;
            xDoc.Root.Add(newProduct);
            //Task 2: Update product
            XElement productToUpdate = xDoc.Descendants("Product").FirstOrDefault(p=>(int)p.Element("ID")==2);
            if(productToUpdate !=null)
            {
                int stock = (int)productToUpdate.Element("ID");
                if(stock>30)
                {
                    productToUpdate.Element("Price").Value = "850";
                }
            }

            //remove product in the stock level

            var ProductToRemove = xDoc.Descendants("Product").Where(p => (int)p.Element("stock") < 10).ToList();
            foreach(var product in ProductToRemove)
            {
                product.Remove();
            }
            //Sort the product in acending order
            var SortedProduct = xDoc.Descendants("Product").OrderBy(p => (int)p.Element("ID")).ToList();
            xDoc.Root.RemoveAll();
            xDoc.Root.Add(SortedProduct);
            xDoc.Save("UpdatedProduct.xml");
            Console.WriteLine("XML file updated successfully");
        }
    }
}