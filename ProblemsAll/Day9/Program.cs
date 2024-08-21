
namespace Day9
{
    interface Itest
    {
        void TestMethod();
    }
    class TestClass:Itest
    {
        public void TestMethod()
        {
            Console.WriteLine("Implicite interface implimentation");
        }

    }
    class ExplicitTestClass:Itest
    {
        void Itest.TestMethod()
        {
            Console.WriteLine("Explicit interfacebimplimenation");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}