namespace Paliandrome_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to check wheather Paliandrome:");
            string name = Console.ReadLine();

            string Reverse = String.Empty;
            for (int i= name.Length-1;i>=0;i--)

            {
                Reverse += name[i];
            }
            if(name==Reverse)
            {

            Console.WriteLine($"{name} is paliandrom");

            }
            else
            {
                Console.WriteLine($"{name} Not a paliandrome");
            }
        }
    }
}