//Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел. 
//Определите интерфейс для функции сложения числа и реализуйте его.
//Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.
namespace Modul10Task1
{
    class Calculator : ICalculator
    {
        public void Div()
        {
            Console.WriteLine("Операция деления\nВведите первый операнд");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:\n" + (a / b));
        }

        public void Mult()
        {
            Console.WriteLine("Операция умножения\nВведите первый операнд");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:\n" + (a * b));
        }

        public void Subtr()
        {
            Console.WriteLine("Операция вычитания\nВведите первый операнд");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:\n" + (a - b));
        }

        public void Sum()
        {
            Console.WriteLine("Операция сложения\nВведите первый операнд");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:\n" + (a + b));
        }
    }
}
