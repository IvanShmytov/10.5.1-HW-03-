using System;
//Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел. 
//Определите интерфейс для функции сложения числа и реализуйте его.
//Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.
namespace Modul10Task1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            try
            {
                ICalculator calc = new Calculator();
                Console.WriteLine("Выберите операцию\n1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        calc.Sum();
                        break;
                    case 2:
                        calc.Subtr();
                        break;
                    case 3:
                        calc.Mult();
                        break;
                    case 4:
                        calc.Div();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
