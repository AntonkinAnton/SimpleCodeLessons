using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCodeLessons
{
    public class MyMethods
    {
        public static int GetNum(string message)
        {
            int num;
            do
            {
                System.Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out num));
            return num;
        }

        public static void PrintArray(int[] array, string message)
        {
            System.Console.WriteLine(message);
            for (int i = 0; i < array.Length; i++)
            {


                System.Console.Write("{0,3}", array[i]);

                
            }
            
        }




    }
}
