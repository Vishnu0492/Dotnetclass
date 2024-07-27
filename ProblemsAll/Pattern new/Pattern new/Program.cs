// See https://aka.ms/new-console-template for more information

        Console.WriteLine("Display like the pattern like right angle");
        Console.WriteLine("input the number of rows");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = rows; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.WriteLine(j.ToString());
                Console.Write("*");

            }
        }
        for (int i = 1; i >= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.WriteLine(j.ToString());
                Console.Write("*");

            }
            Console.WriteLine();
        }

    
