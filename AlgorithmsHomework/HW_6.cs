using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHomework
{
    class HW_6
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
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 8");
                    break;
            }
        }
    }
}
