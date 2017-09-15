using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace ex6
{
    internal class Program
    {
        private static void Main()
        {
            double start = Ask.RealNum("Введите первое число последовательности: "),
                twoNum = Ask.RealNum("Введите второе число последовательности: "),
                threeNum = Ask.RealNum("Введите третье число последовательности: "),
                end = Ask.RealNum("Введите границу последовательности: ");

            var num = 4;
            var last = next(start, twoNum, threeNum);

            Console.WriteLine("Последовательность: ");
            Console.Write("{0} {1} {2} {3} ", start, twoNum, threeNum, last);

            while (last < end)
            {
                start = twoNum;
                twoNum = threeNum;
                threeNum = last;
                last = next(start, twoNum, threeNum);
                Console.Write(last + " ");
            }

            Console.WriteLine("\n Номер последнего элемента: {0}" +
                              "\n Последний элемент равен границе: {1}", num - 1, last.Equals(end));
            OC.Stay();
        }
        
        static double next(double a1, double a2, double a3)
        {
            // по сути - можно сложить и потом поделить
            // но изменять формулу из задания не будем
            return a3 / 2 + a2 / 2 + a1 / 2;
        }
    }
}
