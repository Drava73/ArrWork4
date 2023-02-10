using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArrWork4
{
   
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex1
            /* int[] A = new int[5];
             int max = 0, min = 0;
             double maxd = 0, mind = 0;
             double[,] B = new double[3, 4];
             Console.WriteLine("Input five numbers:");
             for (int i = 0; i < A.Length; i++)
             {
                 A[i] = Convert.ToInt32(Console.ReadLine());
             };
             Console.WriteLine("Array int :");
             for (int i = 0; i < A.Length; i++)
             {
                 Console.Write("{0,4}", A[i]);
             };
             Random r = new Random();
             Console.WriteLine("\nArray double :");
             for (int i = 0; i < B.GetLength(0); i++)
             {
                 Console.WriteLine("\n");
                 for (int j = 0; j < B.GetLength(1); j++)
                 {
                     B[i, j] = r.NextDouble() * 100;
                     Console.Write("{0:F2}\t", B[i, j]);
                 };
             };
             min = A[0];
             mind = B[0, 0];
             int sum = 0, proizv = 1, tchetsum = 0;
             double sumd = 0, proizvd = 1, tchetsumd = 0;
             for (int i = 0; i < A.Length; i++)
             {
                 if (max <= A[i])
                 {
                     max = A[i];
                 }
                 if (min >= A[i])
                 {
                     min = A[i];
                 }
                 sum += A[i];
                 proizv *= A[i];
                 if ((A[i] % 2) == 0)
                 {
                     tchetsum += A[i];
                 }

             };
             for (int i = 0; i < B.GetLength(0); i++)
             {

                 for (int j = 0; j < B.GetLength(1); j++)
                 {
                     if (maxd <= B[i, j])
                     {
                         maxd = B[i, j];
                     }
                     if (mind >= B[i, j])
                     {
                         mind = B[i, j];
                     }
                     sumd += B[i, j];
                     proizvd *= B[i, j];
                     if ((B[i, j] % 2) != 0)
                     {
                         tchetsumd += B[i, j];
                     }
                 };
             };
             Console.Write($"\nMax number in int array:{max} \nMin number in int array:{min}\nSumm:{sum}\nProizv:{proizv}\nTchetSum:{tchetsum}");
             Console.Write($"\nMax number in double array:{maxd}\nMin number in double array:{mind}\nSumm:{sumd}\nProizv:{proizvd}\nTchetSum:{tchetsumd}\n CONVERT TO INT:");
             Console.Write(Convert.ToInt32(maxd));
             if (maxd > max)
             {
                 Console.Write($"\n{Convert.ToInt32(maxd)}>{max}");
             }
             if (maxd < max)
             {
                 Console.Write($"\n{Convert.ToInt32(maxd)}<{max}");
             }
             Console.ReadLine();
 */
            #endregion
            #region Ex2
            /*            int maxd = 0, mind = 0, sum = 0;
                        int[,] B = new int[5, 5];
                        Random r = new Random();
                        Console.WriteLine("\nArray int[5-5] :");
                        for (int i = 0; i < B.GetLength(0); i++)
                        {
                            Console.WriteLine("\n");
                            for (int j = 0; j < B.GetLength(1); j++)
                            {
                                B[i, j] = r.Next(-100, 100);
                                Console.Write("{0,4}", B[i, j]);
                            };
                        };
                        int a = 0;
                        mind = B[0, 0];
                        for (int i = 0; i < B.GetLength(0); i++)
                        {

                            for (int j = 0; j < B.GetLength(1); j++)
                            {
                                if (maxd <= B[i, j])
                                {
                                    maxd = B[i, j];
                                }
                                if (mind >= B[i, j])
                                {
                                    mind = B[i, j];
                                }
                            };
                        };
                        for (int i = 0; i < B.GetLength(0); i++)
                        {
                            for (int j = 0; j < B.GetLength(1); j++)
                            {
                                if ((B[i, j]) == maxd)
                                {
                                    for (int k = i; k < B.GetLength(0); k++)
                                    {
                                        for (int l = j; l < B.GetLength(1); l++)
                                        {
                                            sum += B[k, l];
                                            a++;
                                            if ((B[i, j]) == mind)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                };
                                if ((B[i, j]) == mind)
                                {
                                    for (int k = i; k < B.GetLength(0); k++)
                                    {
                                        for (int l = j; l < B.GetLength(1); l++)
                                        {
                                            sum += B[k, l];
                                            a++;
                                            if ((B[i, j]) == maxd)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                };
                            };
                        };
                        Console.Write($"\nMax number in array:{maxd}\nMin number in array:{mind}\nSumm:{sum}\nElements:{a}");

                        Console.ReadLine();*/
            #endregion
            #region Ex3
            /*const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            const string alfabet2 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string s2;
            Console.Write("Введите строку:");
            string s = Console.ReadLine();
            Console.Write("Введите ключ:");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Ключ - {key} - ");
            for (int i = 0; i < s.Length; i++) {
                for(int j = 0; j < alfabet.Length; j++)
                {
                    if (s[i] == alfabet[j])
                    {
                        Console.Write(alfabet[j + key]);
                        s2 = Convert.ToString(alfabet[j + key]);
                        break;
                    }
                    if (s[i] == alfabet2[j])
                    {
                        Console.Write(alfabet2[j + key]);
                        s2 = Convert.ToString(alfabet2[j + key]);
                        break;
                    }
                }
            };
            Console.ReadLine();*/
            #endregion
            #region Ex4
            /*Random r = new Random();
            Console.Write("Создайте матрицу!\nВведите столбцы и строки:");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size1, size2];
            Console.WriteLine($"\nВаша матрица {size1} на {size2} :");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0, 10);
                    Console.Write("{0,4}", matrix[i, j]);
                };
            };
            Console.Write("\n1.Умножение матрицы на число\n2.Сложение матриц(будет создана дополнительная матрица)\n3.Произведение матриц(будет создана дополнительная матрица)\nВведите Ваш выбор:");
            int vib = Convert.ToInt32(Console.ReadLine());
            switch (vib) {
                case 1:
                    Console.Write("\nВведите число:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Console.WriteLine("\n");
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = matrix[i, j]*num;
                            Console.Write("{0,4}", matrix[i, j]);
                        };
                    };
                    break;
                case 2:
                    Console.Write("\nДоп.матрица создана");
                    int[,] matrix2 = new int[size1, size2];
                    for (int i = 0; i < matrix2.GetLength(0); i++)
                    {
                        Console.WriteLine("\n");
                        for (int j = 0; j < matrix2.GetLength(1); j++)
                        {
                            matrix2[i, j] = r.Next(0, 10);
                            Console.Write("{0,4}", matrix2[i, j]);
                        };
                    };
                    Console.Write("\nМатрицы сложены ->");
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Console.WriteLine("\n");
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = matrix[i, j]+matrix2[i, j];
                            Console.Write("{0,4}", matrix[i, j]);
                        };
                    };
                    break;
                case 3:
                    int[,] matrix3 = new int[size1, size2];
                    Console.Write("\nДоп.матрица создана");
                    for (int i = 0; i < matrix3.GetLength(0); i++)
                    {
                        Console.WriteLine("\n");
                        for (int j = 0; j < matrix3.GetLength(1); j++)
                        {
                            matrix3[i, j] = r.Next(0, 10);
                            Console.Write("{0,4}", matrix3[i, j]);
                        };
                    };
                    Console.Write("\nМатрицы перемножены ->");
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        Console.WriteLine("\n");
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = matrix[i, j] * matrix3[i, j];
                            Console.Write("{0,4}", matrix[i, j]);
                        };
                    };
                    break;
                default:
                    Console.Write("Ошибка");
                    break;
            };
            Console.ReadLine();*/
            #endregion
        }
    }
}
