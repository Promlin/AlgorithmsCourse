using System;
using System.Security.Cryptography;
using System.Text;

namespace AlgorithmsHomework
{
    class HW_6
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
                    secondExercise();
                    break;
                default:
                    Console.WriteLine("Ошибка при вводе. Введите число от 1 до 2");
                    break;
            }
        }

        //Реализовать простейшую хеш-функцию. На вход функции подается строка, на выходе сумма кодов символов.
        public static void firstExercise()
        {
            string sSourceData;
            byte[] tmpSource;
            byte[] tmpHash;

            Console.WriteLine("Данные считываются из файла. Получившийся хэш-код: ");
            sSourceData = "MySourceData";
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);

            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            Console.WriteLine(ByteArrayToString(tmpHash));
            

        }
        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        //Переписать программу, реализующую двоичное дерево поиска.
        //а) Добавить в него обход дерева различными способами;
        //б) Реализовать поиск в двоичном дереве поиска;
        public static void secondExercise()
        {
            BinaryTree<int> tree = new BinaryTree<int>(33, null);
            //for (int i = 3; i < 9; i =+ 2)
            //{
            //    tree.add(i);
            //}
            tree.add(7);
            tree.add(11);
            tree.add(2);
            tree.print();
        }
    }
}
