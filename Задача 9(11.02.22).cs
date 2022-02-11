using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Программа калькулятор,запрашивает 2 числа, выполняет 4 типа операций, предусмотрены исключения

            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите целое число, Х: ");
            #region
            int X = 0;
            while (true)
            {
                var x = Console.ReadLine();
                if (Int32.TryParse(x, out X))
                {
                    X = Convert.ToInt32(x);
                    break;

                }
                else
                {
                    Console.WriteLine("Ошибка! Входная строка имела неверный формат");
                }
            }
            #endregion

            Console.WriteLine("Введите целое число, Y: ");
            #region
            int Y = 0;
            while (true)
            {
                var y = Console.ReadLine();
                if (Int32.TryParse(y, out Y))
                {
                    Y = Convert.ToInt32(y);
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Входная строка имела неверный формат");
                }
            }
            #endregion

            Console.WriteLine("Выберите код требуемой операции: ");
            Console.WriteLine("1 - сложение ");
            Console.WriteLine("2 - вычитание ");
            Console.WriteLine("3 - произведение");
            Console.WriteLine("4 - частное");
            Console.WriteLine("Ваш выбор: ");

            int input = 0;
            #region
            while (true)
            {
                string i = Console.ReadLine();
                if (Int32.TryParse(i, out input))
                {
                    input = Convert.ToInt32(i);
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Входная строка имела неверный формат");
                }
            }
            #endregion
            int one = X + Y;
            int two = X - Y;
            int three = X * Y;
            double four=((double)X / Y); 
           
            #region
            while (true)
            {
                if ((X < Y) && (Y > 0) && (input == 2))
                {
                    two = Math.Abs(Y - X);
                    Console.WriteLine("Результат: -{0}", two);
                    Console.ReadKey();
                    break;

                }
                if ((X < Y) && (Y < 0) && (X < 0) && (input == 2))
                {
                    two = Math.Abs(Y - X);
                    Console.WriteLine("Результат: {0}", two);
                    Console.ReadKey();
                    break;

                }
                if ((X < 0) && (Y < 0) && (input == 1))
                {
                    one = Math.Abs(X + Y);
                    Console.WriteLine("Результат: -{0}", one);
                    Console.ReadKey();
                    break;

                }
                if ((X < 0) && (Y < 0) && (input == 3))
                {
                    three = Math.Abs(X * Y);
                    Console.WriteLine("Результат: -{0}", three);
                    Console.ReadKey();
                    break;

                }
                if ((X < 0) && (Y < 0) && (input == 4))
                {
                    four = Math.Abs(X / Y);
                    Console.WriteLine("Результат: -{0}", four);
                    Console.ReadKey();
                    break;

                }
                if ((X == 0) || (Y == 0) && (input == 4))
                {
                    
                    Console.WriteLine("Ошибка! Деление на 0");
                    Console.ReadKey();
                    break;

                }
                if ((X == 0) && (Y == 0) && (input == 4))
                {

                    Console.WriteLine("Ошибка! Деление на 0");
                    Console.ReadKey();
                    break;

                }
                if (input == 1)
                {
                    Console.WriteLine("Результат: {0}", one);
                    break;
                }
                if (input == 2)
                {
                    Console.WriteLine("Результат: {0}", two);
                    break;
                }
                if (input == 3)
                {
                    Console.WriteLine("Результат: {0}", three);
                    break;
                }
                if (input == 4)
                {
                    Console.WriteLine("Результат: {0}", Math.Round(four, 2));
                    break;
                }
                else
                {
                    Console.WriteLine("Операции с данным номером нет");
                    break;
                }
                #endregion
            }


            Console.ReadKey();

            // try
           // {
              //  four = (



           // }
           // catch (DivideByZeroException) when (X == 0 || Y == 0)
           // {
               // Console.WriteLine("Ошибка! Деление на 0");
               // Console.ReadKey();
           // }
           // catch (DivideByZeroException) when (X == 0 && Y == 0)
            //{
               // Console.WriteLine("Ошибка!");
              //  Console.ReadKey();
           // }
           // catch (Exception ex)
           // {
             //   Console.WriteLine("Ошибка!");
            //    Console.ReadKey();
          //  }
        }
    }
}
