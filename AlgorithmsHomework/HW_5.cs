using System;
using System.Collections.Generic;

namespace AlgorithmsHomework
{
    class HW_5
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
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 3");
                    break;
            }
        }

        public static void firstExercise()
        {
            Console.WriteLine("Введите число для перевода в двоичную систему счисления");
            int number = int.Parse(Console.ReadLine());
            int startNumber = number;

            var stack = new Stack<int>();
            while (number > 0)
            {
                stack.Push(number % 2);
                number /= 2;
            }

            Console.Write($"Число {startNumber} в двоичной системе счисления: ");

            foreach (int i in stack)
                Console.Write(i);

            Console.WriteLine(" ");
        }
    }
}
