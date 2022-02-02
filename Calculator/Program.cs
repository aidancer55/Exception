using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a2 = Console.ReadLine();
            string b2 = Console.ReadLine();
            int num;
            bool a1 = int.TryParse(a2, out num);
            bool b1 = int.TryParse(b2, out num);
            if (!a1 || !b1 )
            {
                Console.WriteLine($"Ошибка! Входная строка имела неверный формат!");
            }
            else
            {
                int a = Convert.ToInt32(a2);
                int b = Convert.ToInt32(b2);
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.WriteLine("Введите целое число. Х={0}", a);
                Console.WriteLine("Введите целое число. Y={0}", b);
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("\t" + "1 - сложение");
                Console.WriteLine("\t" + "2 - вычитание");
                Console.WriteLine("\t" + "3 - произведение");
                Console.WriteLine("\t" + "4 - частное");
                Console.WriteLine("Ваш выбор: {0}", c);

                if (c == 1)
                {
                    Console.WriteLine("Результат = {0}", a + b);
                }
                else if (c == 2)
                {
                    Console.WriteLine("Результат = {0}", a - b);
                }
                else if (c == 3)
                {
                    Console.WriteLine("Результат = {0}", a * b);
                }
                else if (c == 4)
                {
                    try
                    {
                        Console.WriteLine("Решение = {0}", a / b);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером!");
                }
            }
            Console.ReadKey();
        }
    }
}
