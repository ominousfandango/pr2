using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_2
{
    class Zadanie
    {
        private int n = 0;
        private int number;

        public Zadanie(int number) {

            this.number = number;

        }

        public bool SetNumber(int number)
        {

            if (number == n + 1) {
                n++;
                return true;
            }

            else {
            n = 0; return false;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool pro = true;
            int n = 1;
            Zadanie set = new Zadanie(n);

            while (pro == true)
            {

            Console.WriteLine("введите число: " + n);
            n = Convert.ToInt32(Console.ReadLine());
            pro = set.SetNumber(n);
            if (n == 0) { 
            n = n + 1; pro = true; 
            }

            n++;

            }
            Console.ReadKey(true);
        }
    }
}
