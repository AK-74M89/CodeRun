using System;

namespace CodeRun
{
    internal class Triangle
    {
        /// <summary>
        /// Треугольник
        /// Даны три натуральных числа. Возможно ли построить треугольник с такими сторонами?
        /// Если это возможно, выведите строку YES, иначе выведите строку NO.
        /// Треугольник — это три точки, не лежащие на одной прямой.
        /// Формат ввода
        /// Вводятся три натуральных числа.
        /// Формат вывода
        /// Выведите ответ на задачу.
        /// </summary>
        public static void Solve()
        {
            Console.WriteLine("Введите три натуральных числа. Возможно ли построить треугольник с такими сторонами?");
            var sides = new int[3];
            for (int i = 0; i < sides.Length; i++)
            {
                int side;
                while (!int.TryParse(Console.ReadLine(), out side))
                    Console.WriteLine("Введите натуральное число.");
                sides[i] = side;
                Console.WriteLine("Принято");
            }
            var sum1 = sides[0] + sides[1];
            var sum2 = sides[1] + sides[2];
            var sum3 = sides[0] + sides[2];
            if (sum1 > sides[2] && sum2 > sides[0] && sum3 > sides[1])
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
