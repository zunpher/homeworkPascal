using System;
namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input row of Pascal's Triangle: ");
                int row = int.Parse(Console.ReadLine());
                int rowCTRL = row + 1;

                if (rowCTRL > 0)
                {
                    int[,] triangle = new int[rowCTRL, rowCTRL];

                    for (int i = 0; i < rowCTRL; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            if (j == 0)
                            {
                                triangle[i, j] = 1;
                            }
                            else
                            {
                                triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                            }
                        }
                    }

                    for (int i = 0; i < rowCTRL; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(triangle[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.");
                }
            }
        }
    }
}