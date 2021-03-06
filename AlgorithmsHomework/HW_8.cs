﻿using System;


namespace AlgorithmsHomework
{
    class HW_8
    {
        public static void RunExercises()
        {
            Console.WriteLine("Введите номер упражнения 1 - 2");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    firstExercise();
                    break;
                case 2:
                    int[] array = gettingArray();
                    Console.WriteLine("Введите длину массива");
                    int arrayLength = int.Parse(Console.ReadLine());
                    secondExercise(array, 0, arrayLength);
                    break;
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 2");
                    break;
            }
        }

        //Реализовать сортировку подсчетом
        public static void firstExercise()
        {
            int[] array = gettingArray();
            int k = 100; //максимальное допустимое число

            var count = new int[k + 1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            }

            printArray(array);
        }

        //Реализовать быструю сортировку.
        public static void secondExercise(int[] array, int first, int last)
        {
            double p = array[(last - first) / 2 + first];
            int temp;
            int i = first;
            int j = last;
            while (i <= j)
            {
                while (array[i] < p && i <= last) ++i;
                while (array[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) secondExercise(array, first, j);
            if (i < last) secondExercise(array, i, last);
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
