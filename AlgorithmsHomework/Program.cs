using System;


//Тюмянцева Ирина
namespace AlgorithmsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            do
            {
                Console.WriteLine("Для начала работы программы введите любое число не равное 0, для прекращения - введите 0");
                String input = Console.ReadLine();
                bool choose = Int32.TryParse(input, out number);
                if (choose)
                {
                    if (number != 0) choosingNumber();
                }
                else { Console.WriteLine("Ошибка при вводе"); }
            }
            while (number != 0);
        }

        public static void choosingNumber()
        {
            Console.WriteLine("Введите номер домашнего задания ");
            int hwNumber = int.Parse(Console.ReadLine());

            switch (hwNumber)
            {
                case 1:
                    HW_1.RunExercises();
                    break;
                case 2:
                    HW_2.RunExercises();
                    break;
                case 3:
                    HW_3.RunExercises();
                    break;
                default:
                    Console.WriteLine("Введено некорректное число");
                    break;
            }
        }
    }
}
