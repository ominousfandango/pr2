using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace pr2_3
{
    class Zadanie
    {
        private static string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private string text;
        public Zadanie(string text)
        {
            this.text = text;
        }

        public static string Shifr(string text) {
        var a = new StringBuilder();
            for (int i = 0; i < text.Length; i++)

                for (int j = 0; j < alph.Length; j++)

                    if (text[i] == alph[j]) a.Append(alph[(j + 6) % alph.Length]);

            return a.ToString();
        }
    }
    class Onet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст для перевода в шифр Цезаря: ");

            string text = Convert.ToString(Console.ReadLine());
            Zadanie Tri = new Zadanie(text);
            Console.WriteLine("перевод в шифр Цезаря: " + Zadanie.Shifr(text));

            Console.ReadKey(true);
        }
    }
}
