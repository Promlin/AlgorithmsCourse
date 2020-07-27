using System;


namespace AlgorithmsHomework
{
    class HW_4
    {
        #region Fields
        static int m, n;
        static int[,] c = new int[20, 20];
        static char[] x = new char[20];
        static char[] y = new char[20];
        static char[,] b = new char[20, 20];
        #endregion

        public static void RunExercises()
        {
            Console.WriteLine("Введите номер упражнения - 2");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 2:
                    secondExercise();
                    Console.WriteLine(" ");
                    printCharArray(b);
                    Console.WriteLine(" ");
                    printIntArray(c);
                    break;
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число 2");
                    break;
            }
        }

        //Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.
        private static void secondExercise()
        {
            Console.WriteLine("Введите первую последовательность");
            x = Console.ReadLine().ToCharArray();
            Console.WriteLine("Введите вторую последовательность");
            y = Console.ReadLine().ToCharArray();
            Console.WriteLine("Наибольшая общая последовательность: ");
            lcs();
            print(m, n);
        }

        private static void print(int i, int j)
        {
            if (i == 0 || j == 0) return;
            if( b[i,j] == 'c')
            {
                print(i - 1, j - 1);
                Console.Write(x[i - 1]);
            }
            else if(b[i,j] == 'u')
            {
                print(i - 1, j);
            }
            else
            {
                print(i, j - 1);
            }
        }

        private static void lcs()
        {
            m = x.Length;
            n = y.Length;

            for(int i = 0; i <= m; i++)
            {
                c[i, 0] = 0;
            }

            for(int i = 0; i <= n; i++)
            {
                c[0, i] = 0;
            }

            for(int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(x[i-1] == y[j - 1])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        b[i, j] = 'c';
                    }
                    else if(c[i-1, j] >= c[i, j - 1])
                    {
                        c[i, j] = c[i - 1, j];
                        b[i, j] = 'u';
                    }
                    else
                    {
                        c[i, j] = c[i, j - 1];
                        b[i, j] = 'l';
                    }
                }
            }
        }

        private static void printCharArray(char[,] array)
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void printIntArray(int[,] array)
        {
            int height = array.GetLength(0);
            int width = array.GetLength(1);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
