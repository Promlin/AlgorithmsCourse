using System;


namespace AlgorithmsHomework
{
    class HW_1
    {
        public static void RunExercises()
        {
            Console.WriteLine("Введите номер упражнения 1 - 8");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    firstExercise();
                    break;
                case 2:
                    secondExercise();
                    break;
                case 3:
                    thirdExercise();
                    break;
                case 4:
                    fourthExercise();
                    break;
                case 5:
                    fifthExercise();
                    break;
                case 6:
                    sixthExercise();
                    break;
                case 7:
                    seventhExercise();
                    break;
                case 8:
                    eighthExercise();
                    break;
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 8");
                    break;
            }
        }

        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
        //где m — масса тела в килограммах, h — рост в метрах.

        public static void firstExercise()
        {
            Console.WriteLine("Рассчет индекса массы тела");
            Console.WriteLine("Введите Ваш рост (целое значение)");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес (целое значение)");
            int weight = int.Parse(Console.ReadLine());
            if (height != 0)
            {
                float a = height * height;
                float b = weight / a;
                Console.WriteLine("Индекс массы тела равен " + b);
            }
            else
            {
                Console.WriteLine("Убедитесь в правильности данных");
            }
            Console.ReadLine();
        }

        //Найти максимальное из четырех чисел. Массивы не использовать.

        public static void secondExercise()
        {
            Console.WriteLine("Найти максимальное из четырех чисел");
            Console.WriteLine("Введите через Enter 4 числа");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());

            int max = x1;

            if (x2 > max) max = x2;
            if (x3 > max) max = x3;
            if (x4 > max) max = x4;

            Console.WriteLine("Наибольшее число: " + max);

        }

        //Написать программу обмена значениями двух целочисленных переменных:
        //a.с использованием третьей переменной;
        //b. * без использования третьей переменной.

        public static void thirdExercise()
        {
            Console.WriteLine("Программа для обмена местами значений переменных");
            Console.WriteLine("Введите значение х (целое значение)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение у (целое значение)");
            int y = int.Parse(Console.ReadLine());
            //int c = x; С использованием третьей переменной
            //x = y;
            //y = c;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Значение x - " + x + " Значение y - " + y);
            Console.ReadLine();
        }

        //Написать программу нахождения корней заданного квадратного уравнения.

        public static void fourthExercise()
        {
            Console.WriteLine("Нахождение корней квадратного уравнения");
            Console.WriteLine("Введите черех Enter коэффициенты уравнения: a*x^2 + b*x + c = 0");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            double x1 = Math.Round((-b - Math.Sqrt(d)) / (2 * a), 5);
            double x2 = Math.Round((-b + Math.Sqrt(d)) / (2 * a), 5);

            Console.WriteLine($"Корни уравнения: {x1} и {x2}");
        }

        //С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.

        public static void fifthExercise()
        {
            Console.WriteLine("Определение времени года по номеру месяца");
            Console.WriteLine("Введите номер месяца");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Зима!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень!");
                    break;
                default:
                    Console.WriteLine("Допущена ошибка");
                    break;
            }
        }

        //Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».

        public static void sixthExercise()
        {
            Console.WriteLine("Упражнение для вывода количества лет");
            Console.WriteLine("Введите возраст");
            int age = int.Parse(Console.ReadLine());
            if (age > 1 && age < 150)
            {
                Console.WriteLine($"Возраст человека {age} лет");
            }
            else
            {
                Console.WriteLine("Указан неверный возраст");
            }
        }

        //С клавиатуры вводятся числовые координаты двух полей шахматной доски (x1,y1,x2,y2). 
        //Требуется определить, относятся поля к одному цвету или нет.

        public static void seventhExercise()
        {
            Console.WriteLine("Определение цвета поля на шахмотной доске");

            Console.WriteLine("Введите через Enter координаты первой фигуры");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            CheckingForColor(x1, y1);

            Console.WriteLine("Введите через Enter координаты второй фигуры");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            CheckingForColor(x2, y2);
        }

        public static void CheckingForColor(int x, int y)
        {
            if (x % 2 == 1 && y % 2 == 1 || x % 2 == 0 && y % 2 == 0)
            {
                Console.WriteLine("Фигура находится на черном поле");
            }
            else
            {
                Console.WriteLine("Фигура находится на белом поле");
            }
        }

        //Ввести a и b и вывести квадраты и кубы чисел от a до b.

        public static void eighthExercise()
        {
            Console.WriteLine("Вывод кубов чисел");
            Console.WriteLine("Введите меньшее число");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите большее число");
            int max = int.Parse(Console.ReadLine());
            if (min < max)
            {
                for (int i = min; min <= max; i++)
                {
                    Console.WriteLine($"Куб числа {i}: " + i * i * i);
                }
            }
            else
            {
                Console.WriteLine("Допущена ошибка при вводе данных");
            }
        }
    }
}
