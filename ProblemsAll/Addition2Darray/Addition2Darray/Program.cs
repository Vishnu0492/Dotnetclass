namespace Addition2Darray
{
    internal class arrays
    {
        static void Main(string[] args)
        {
            int[,] a1 = new int[4, 4];
            int[,] b1 = new int[2, 2];
            Console.WriteLine("Enter the rows:");
            int row = Convert.ToInt16(Console.ReadLine());

            int row = a1.Length;
            int col = b1.Length;
            int[,] result = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[i, j] = a1[i, j] + b1[i, j];
                }
           
            }
            Console.WriteLine("result of addition");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(result[i, j]+"");
                }
                Console.WriteLine();
            }
        }


            
    }
}