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
                    Console.WriteLine("Введите число");
                    int numberToMultiply = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите необходимую степень");
                    int degree = int.Parse(Console.ReadLine());
                    float result = secondExercise(numberToMultiply, degree);
                    Console.WriteLine($"Результат {result}");
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

        public static float secondExercise(int number, int degree)
        {
            // int startNumber = number; //без использования рекурсии
            // for (int i = 1; i < degree; i++)
            // {
            //    number = number * startNumber;
            // }
            //return number;

            if (degree == 0)
                return 1;
            if (degree > 0)
                return secondExercise(number, degree - 1) * number;
            return 1.0f / (secondExercise(number, -degree));

        }
    }
}
