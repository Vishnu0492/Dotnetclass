namespace Overriding
{

    public class overloadingdemo
    {
        public void sum()
        {

            Console.WriteLine(1 + 2);
        }
        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);

        }
        public void sum(String a, String b)
        {
            Console.WriteLine(a + b);
        }
    }
    internal class overloading
    {
        public static void Main()
        {

            overloadingdemo overloadingdemo = new overloadingdemo();
            overloadingdemo.sum();
            overloadingdemo.sum(1, 2);
            overloadingdemo.sum("1", "2");
        }

    }
}