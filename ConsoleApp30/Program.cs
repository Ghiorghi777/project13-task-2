using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {/// <summary>
     /// По номеру месяца вывести его название.
     /// </summary>
        static int Input(string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int moth = Input("moth=");
            string m = GetMoth(moth);
            Console.WriteLine(GetMoth(moth));
            Console.ReadKey();

        }

        static string GetMoth(int moth)
        {
            switch (moth)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default: return "Ошибка";
            }
        }
    }
}
