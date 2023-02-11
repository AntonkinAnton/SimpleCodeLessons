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
            double[] arrayDoubles = new double[4];

            int[] arrayInteger = new int[4];

            FillArrayRndm(arrayDoubles);

            FillArrayRndm(arrayInteger);

            PrintArray(arrayDoubles, "Ваш массив doubles:");

            PrintArray(arrayInteger, "Ваш массив integer:");

            End();

        }
    }
}
