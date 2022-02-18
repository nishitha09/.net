using System;

namespace Exercises
{
    class SumofDiagonals
    {
        static void Main(string[] args)
        {
            int MaxRow, MaxCol, Sum = 0;
            int[,] Matrix;
            Console.WriteLine("\n ___SUM OF DIAGONAL OF A MATRIX___\n");
            Console.Write("\n Enter the number of rows:");
            MaxRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the number of columns:");
            MaxCol = Convert.ToInt32(Console.ReadLine());
            if (MaxRow != MaxCol)
            {
                Console.WriteLine("\n The Dimensions entered are not a square matrix");
                Console.WriteLine("\n Exiting the program");
                return;
            }
            Matrix = new int[MaxRow, MaxCol];
            for (int i = 0; i < MaxRow; i++)
            {
                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write("\n Enter the ({0},{1})th element of matrix:", (i + 1), (j + 1));
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n the entered Matrix is:");
            for (int i = 0; i < MaxRow; i++)
            {

                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write(" " + Matrix[i, j]);
                    if (i == j)
                    {
                        Sum += Matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n The Sum of Diagonal is" + Sum);
        }
    }
}   

    
       