using System;


namespace AlgorithmsHomework
{
    class HW_2
    {
        public static void RunExercises()
        {
            Console.WriteLine("Введите номер упражнения 1 - 2");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    Console.WriteLine("Введите число в десятичной системе счисления");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите систему счисления");
                    int notation = int.Parse(Console.ReadLine());
                    firstExercise(number, notation);
                    Console.WriteLine(" ");
                    break;
                case 2:
                    secondExercise();
                    break;
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 2");
                    break;
            }
        }

        // Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.

        public static void firstExercise(int number, int notation)
        {
            if (number > 1)
                firstExercise(number / notation, notation);
            Console.Write(number % notation);
        }


        //Реализовать функцию возведения числа a в степень b:
        //a.без рекурсии;
        //b.рекурсивно;

        public static void secondExercise()
        {

        }
    }
}
