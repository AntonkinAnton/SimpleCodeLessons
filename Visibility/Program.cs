using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visibility
{
    internal class Program
    {
        static string repeatingValue = "Первый раз объявлена";

        static void SecondTimeDeclare ()
        {
            string repeatingValue = "Второй раз объявлена";
            Console.WriteLine(repeatingValue);

       
        }


        static void Main(string[] args)
        {

            Console.WriteLine(Program.repeatingValue);

            SecondTimeDeclare();

            string repeatingValue = "Третий раз объявлена";

            Console.WriteLine(repeatingValue);

            MyMethods.End();

            


                



          
        }
    }
}
