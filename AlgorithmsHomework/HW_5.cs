using System;


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

        }
    }
}
