using System.Runtime.InteropServices;

namespace VehicleName
{
    internal class Program
    {
        class Vehicle
        {
            private String Name;
            private String Color;

            public Vehicle(Vehicle vehicle)
            {

                Name = vehicle.Name;
                Color = vehicle.Color;
            }
            public Vehicle(String name, String color)
            {
                this.Name = name;
                this.Color = color;
            }
            public void PrintData()
            {
                Console.WriteLine("Name" + Name + ": Color" + Color );
            }
            ~Vehicle()
            {

            }
        }
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("TATA","Red");
            Vehicle v2 = new Vehicle(v1);
            v2.PrintData();
        }
    }
}