using System;
namespace project
{
    class project
    {
        public static int Size = 4;
        static void Main()
        {
            double[,] matrix = new double[Size, Size];
            matrix=fillMatrix(matrix);
            matrix = NotifyFiltersMatrix(matrix);
            printMatrix(matrix);
        }
        private static void printMatrix(double[,] matrix)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        private static double[,] fillMatrix(double[,] matrix)
        {
            for(int i = 0;i < Size; i++)
            {
                for( int j = 0; j < Size; j++)
                {
                    Console.WriteLine("Enter the[" + i + "][" + j + "],element:");
                    matrix[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }
        private static double[,] filterMatrix(double[,] matrix)
        {
            double tempavg = 0;
            for(int i = 1; i < Size-1; i++)
            {
                for(int j = 1; j < Size-1; j++)
                {
                    for (int k =i-1; k <= i + 1; k++)
                    {
                        for(int h =j-1; h <= j + 1; h++)
                        {
                            Console.Write(matrix[k, h] + "-");
                            tempavg += matrix[k, h];
                        }
                    }
                    return matrix;
                }
            }
        }
    }
}
