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
                case 2:
                    Console.WriteLine("К сожалению, второе задание еще не реализовано");
                    break;
                case 3:
                    thirdExercise();
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

            Stack<int> stack = new Stack<int>();
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

        //Написать программу, которая определяет, является ли введенная скобочная последовательность правильной
        public static void thirdExercise()
        {
            Stack<string> Sequence = new Stack<string>();
            Console.WriteLine("Через Enter едите скобочную последовательность для прекращения ввода введите 0");
            float breakNumber = -1.0f;
            int mistakes = 0;

            while (breakNumber != 0)
            {
                string input = Console.ReadLine();

                int number;

                bool succesIntParse = Int32.TryParse(input, out number);
                if (succesIntParse && number == 0)
                {
                    break;
                }

                int numberOfElements1 = Sequence.Count;
                if (numberOfElements1 != 0)
                {

                    switch (input)
                    {
                        case "(":
                            Sequence.Push("(");
                            break;
                        case "{":
                            Sequence.Push("{");
                            break;
                        case "[":
                            Sequence.Push("[");
                            break;
                        case ")":
                            string upValue1 = Sequence.Pop();
                            if (upValue1 != "(" )
                            {
                                mistakes++;
                            }
                            break;
                        case "}":
                            string upValue2 = Sequence.Pop();
                            if (upValue2 != "{")
                            {
                                mistakes++;
                            }
                            break;
                        case "]":
                            string upValue3 = Sequence.Pop();
                            if (upValue3 != "[")
                            {
                                mistakes++;
                            }
                            break;
                        default:
                            Console.WriteLine("Символ не является скобкой");
                            break;
                    }
                }
                else
                {
                    mistakes++;
                }

            }

            if(mistakes != 0)
            {
                Console.WriteLine("Введенная последовательность ошибочна");
            }
            else
            {
                Console.WriteLine("Введенная последовательность верна");
            }
        }
    }
}
