using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_1
{
    class Zadanie
    {
        static void Main(string[] args){
            Urav a = new Urav(2, 6, 1);
            a.CalculateRoots();
            Console.ReadKey(true);
        }
    }
    class Urav
    {
        private double a;
        private double b;
        private double c;

        public Urav(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void CalculateRoots()
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Дискриминант = " + D);
            if (D > 0 || D == 0)
            {
                Console.WriteLine("Уравнение имеет два корня: ");
                Console.WriteLine("");
                double x1 = (-1 * b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-1 * b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = " + x1 + " " + "x2 = " + x2);
            }
            else
                Console.WriteLine("Уравнение не имеет корней");
        }
    }
}
