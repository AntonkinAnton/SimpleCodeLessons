using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleCodeLessons.MyMethods;

namespace SimpleCodeLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = GetNum("Введите X");

            int[] array = CreateArray(x);

            FillArrayRndm(array);

            PrintArray(array, "Ваш массив:");

            RunningString("Пуривет придуркей!!!", 70);

            End();
        }

    }
}
