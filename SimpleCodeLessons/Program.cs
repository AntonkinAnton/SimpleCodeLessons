using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arrayDoubles = new double[9];

            int[] arrayInteger = new int[6];

            MyMethods.FillArrayRndm(arrayDoubles);

            MyMethods.FillArrayRndm(arrayInteger);

            MyMethods.PrintArray(arrayDoubles, "Ваш массив doubles:");

            MyMethods.PrintArray(arrayInteger, "Ваш массив integer:");

            MyMethods.End();

        }
    }
}
