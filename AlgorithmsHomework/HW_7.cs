using System;
using System.IO;
using System.Linq;

namespace AlgorithmsHomework
{
    class HW_7
    {
        public static void RunExercises()
        {
            Console.WriteLine("Введите номер упражнения 1 - 3");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    firstExercise();
                    break;
                case 2:
                    secondExercise();
                    break;
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 3");
                    break;
            }
        }

        //Написать функции, которые считывают матрицу смежности из файла и выводят ее на экран.
        public static void firstExercise()
        {
            int size = 6; //размер массива

            string[] lines = File.ReadAllLines(@"D:\Tests\InputArray.txt").Take(size).ToArray();

            int[,] array = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = row[j];
                }
            }

            Console.Write("    ");
            for(int i = 0; i < size; i++)
            {
                Console.Write($"A({i})  ");
            }
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write($"A({i})   ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + "    ");
                }
                Console.WriteLine();
            }
        }

        public static void secondExercise()
        {
            Random rand = new Random();
            Queue<int> q = new Queue<int>();    //очередь хранящая номера вершин
            int u; //вершина
            u = rand.Next(3, 5);
            bool[] used = new bool[u + 1];  //массив отмечающий посещённые вершины
            int[][] g = new int[u + 1][];   //массив содержащий записи смежных вершин

            Console.Write("    ");
            for (int i = 0; i < u + 1; i++)
            {
                Console.Write($"A({i})  ");
            }
            Console.WriteLine();

            for (int i = 0; i < u + 1; i++)
            {
                g[i] = new int[u + 1];
                Console.Write($"A({i})  " + (i + 1));
                for (int j = 0; j < u + 1; j++)
                {
                    g[i][j] = rand.Next(0, 2);
                }
                g[i][i] = 0;
                foreach (var item in g[i])
                {
                    Console.Write("    {0}", item);
                }
                Console.WriteLine(); 
            }

            used[u] = true;     //массив, хранящий состояние вершины(посещали мы её или нет)

            q.Enqueue(u);
            Console.WriteLine("Начинаем обход с {0} вершины", u + 1);
            while (q.Count != 0)
            {
                u = q.First;
                q.Dequeue();
                Console.WriteLine("Перешли к узлу {0}", u + 1);

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[u][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            q.Enqueue(i);
                            Console.WriteLine("Добавили в очередь узел {0}", i + 1);
                        }
                    }
                }
            }
        }
    }
}
