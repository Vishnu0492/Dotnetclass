using System.Security.Cryptography;

namespace Polymorphism
{
    public class sample
    {
        int Number1, Number2;
        public sample(int a, int b)
        {
            Number1 = a; Number2 = b;
        }
        public void print()
        { Console.WriteLine("Number1:"+Number1 +"Number2:"+Number2);
        
        }
        public static sample operator +(sample s1,sample s2)
        {
            sample s3 = new sample(0, 0);
            s3.Number1 = s1.Number1 + s2.Number2;
            s3.Number2 = s1.Number1 + s2.Number2;
            return s3;


        }
    }
    internal class OperatorOverloading
    {
        public static void Main()
        {
            sample s1 = new sample(1, 2);
            sample s2 = new sample(4, 6);
            sample s3 = s1 + s2;
            s3.print();
        }
      
    }
}