using System;
using System.Threading.Channels;

namespace lab2_2_1
{
    class Program
    {
        public delegate float SampleDelegate(float a, float b, float c);
        public delegate float Calc(float a, float b);

        public delegate int delegate1();
        
        

        static void Main(string[] args)
        {
            float a = 3;
            float b = 4;
            float c = 5;

            // Анонимный метод
            SampleDelegate sd;
            sd = delegate(float a, float b, float c) { return (a+b+c)/3 ; } ;

            //Калькулятор
            Console.Write("   Калькулятор\n\nВведите первое число: ");
            a = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = (float)Convert.ToDouble(Console.ReadLine());

            Calc calc1 = Add;
            Console.WriteLine($"Добавление: {calc1(a, b)}");
            calc1 = Sub;
            Console.WriteLine($"Отнимание: {calc1(a, b)}");
            calc1 = Div;
            Console.WriteLine($"Деление: {calc1(a, b)}");
            calc1 = Mult;
            Console.WriteLine($"Умножение: {calc1(a, b)}");


        }

        private static float Add(float a, float b)
        {
            return a + b;
    }

        private static float Sub(float a, float b)
        {
            return a - b;
        }

        private static float Div(float a, float b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: делимость = 0");
                return 0;
            }
            else
            {
                return a / b;
            }
        }

        private static float Mult(float a, float b)
        {
            return a * b;
        }
        
    }
}
