namespace Callbyref
{
    internal class Outkeyword
    {

        //out
        public static void SumOut(int a, int b,out int Result)
        { Result = a + b;
        }

        //ref
        public static void SumRef(ref int a, ref int b)
        { Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            int Output = 0,a =1,b = 3;
            SumOut(a, b, out Output);
            SumRef(ref a, ref b);
            Console.WriteLine(Output);

        }
    }
}