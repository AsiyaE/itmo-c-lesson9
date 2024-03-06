using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_task1
{
    class Program
    {
        static void Main(string[] args) {

            try
            {
                Console.Write("Введите 1 число ");
                float result = 0;
                float a = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("x={0}", a);
                Console.Write("Введите 2 число ");
                float b = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("x={0}", b);

                Console.WriteLine("Введите код операции");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - произведение");
                Console.WriteLine("4 - частное");

                int operation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор: {0}", operation);


                if (operation > 4 || operation < 1 || (operation == 4 && b == 0))
                {
                    throw new ArgumentOutOfRangeException(nameof(operation), "Выбрана операция вне диапазона или произошло деление на ноль");
                }

                switch (operation)
                {
                    case 1:
                        result = a + b;
                        break;
                    case 2:
                        result = a - b;
                        break;
                    case 3:
                        result = a * b;
                        break;
                    case 4:
                        result = a / b;
                        break;
                    default:

                        break;
                }
                Console.WriteLine("Результат: {0}", result);
            }
            catch (Exception ex)
            {  
                Console.WriteLine(ex.Message);
            };

            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
