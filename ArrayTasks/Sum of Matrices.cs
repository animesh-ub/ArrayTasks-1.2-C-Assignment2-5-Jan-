using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTasks
{
    internal class Sum_of_Matrices
    {
        public static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            
            Console.WriteLine("Enter elements for the first Matrix: ");
            GetMatrixIp(matrix1);

            Console.WriteLine("Enter elements for the second Matrix: ");
            GetMatrixIp(matrix2 );

            int[,] sumMatrix = AddMatrices(matrix1, matrix2);

            Console.WriteLine("Sum of 2 matrices is : ");
            DisplayMatrix(sumMatrix);

            static void GetMatrixIp(int[,] matrix)
            {
                for(int i=0;i<3; i++)
                {
                    for (int j=0;j<3; j++)
                    {
                        Console.Write($"Element at ({i + 1},{j + 1}): ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine()); 
                    }
                }
            }

            static int[,] AddMatrices(int[,] matrix1, int[,] matrix2 )
            {
                int[,] res = new int[3, 3];
                for(int i=0;i<3;i++)
                {
                    for( int j=0;j<3;j++)
                    {
                        res[i,j] = matrix1[i,j] + matrix2[i,j];
                    }
                }
                return res;
            }
        }
        static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i,j]+ " " );
                }
                Console.WriteLine();
            }
        }
       
    }
}
