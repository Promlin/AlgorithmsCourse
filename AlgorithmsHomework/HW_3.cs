using System;


namespace AlgorithmsHomework
{
    class HW_3
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
                    int[] array = gettingArray();
                    secondExercise(array);
                    break;
                case 3:
                    thirdExercise();
                    break;
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 3");
                    break;
            }
        }

        //Пузырьковая сортировка
        public static void firstExercise()
        {
            int[] array = gettingArray();

            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            printArray(array);
        }


        //Шейкерная сортировка
        public static int[] secondExercise(int[] array)
        {
            //int[] array = gettingArray();

            int j = array.Length - 1;
            int k = array.Length - 1;
            int lb = 0;  //левая граница неотсортированной части массива
            int ub = array.Length - 1; // правая граница неотсортированной чатси масива
            int x;

            do
            {
                for (j = ub; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        x = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = x;
                        k = j;
                    }
                }

                lb = k + 1;

                for (j = 1; j <= ub; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        x = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = x;
                        k = j;
                    }
                }

                ub = k - 1;
            } while (lb < ub);

            printArray(array);
            return array;
        }


        //Бинарный алгоритм поиска в отсортированном массиве
        public static void thirdExercise()
        {
            int[] array = gettingArray();
            array = secondExercise(array);

            Console.WriteLine("Введите искомое число");
            int searchValue = int.Parse(Console.ReadLine());
            int leftTerminator = 0;
            int rightTerminator = array.Length - 1;
            int middle = leftTerminator + (rightTerminator - leftTerminator) / 2;

            while(leftTerminator <= rightTerminator && array[middle] != searchValue)
            {
                if(array[middle] <= searchValue)
                {
                    leftTerminator = middle + 1;
                }
                else
                {
                    rightTerminator = middle - 1;
                }
                middle = leftTerminator + (rightTerminator - leftTerminator) / 2;
            }

            if(array[middle] == searchValue)
            {
                Console.WriteLine($"Индекс искомого элемента {middle}");
            }
            else
            {
                Console.WriteLine("Элемент в массиве не найден");
            }

        }

        public static int[] gettingArray()
        {
            Console.WriteLine("Введите размер массива");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            Console.WriteLine("Через Enter введите числа");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        public static void printArray(int[] array)
        {
            Console.Write("Отсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
