using System;


namespace AlgorithmsHomework
{
    class HW_4
    {
        public static void RunExercises()
        {
            Console.WriteLine("Введите номер упражнения 1 - 8");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    //firstExercise();
                    break;
                case 2:
                    //secondExercise();
                    break;
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 8");
                    break;
            }
        }
    }
}
