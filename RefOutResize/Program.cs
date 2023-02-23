using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RefOutResize
{
    internal class Program
    {
        public static void FuncForRef(ref int test)
        {
            test += 2;
            Console.WriteLine("Ваша переменная в функции равна:{0}", test);
        }
        public static void FuncForOut(out int outTest, ref int refTest)
        {
            outTest = 4;
            refTest += 10;
            Console.WriteLine("Вашы переменные out и ref в функции равны:{0}, {1}", outTest, refTest);
        }

        public static void ArraySwaping(ref int[] arra1, ref int[] arra2)
        {
            int[] arrTemp = arra1;
            arra1 = arra2;
            arra2 = arrTemp;
            Console.WriteLine("Ваш первый массив теперь: " + string.Join("-", arra1));
            Console.WriteLine("Ваш второй массив теперь: " + string.Join("-", arra2));

        }
        static void Main(string[] args)
        {
            

            int refTypeVar = 0;
            Console.WriteLine("Ваша переменная в самом начале равна:{0}", refTypeVar);
            FuncForRef(ref refTypeVar);
            Console.WriteLine("Ваша переменная после функции равна:{0}", refTypeVar);

          
            FuncForOut(out int newOut, ref refTypeVar);
            Console.WriteLine("Вашы переменные out и ref за функцией равны:{0}, {1}", newOut, refTypeVar);
            Console.ReadKey();
            Console.Clear();

            int[] firstArr = { 1, 10, 100, 1000};
            string[] stringArr = { "Lol", "Kek", "Chebupeli" };
            int[] secondArr = { 2, 20, 200, 2000 };

            Console.WriteLine("Ваш первый массив: " + string.Join("-", firstArr));
            Console.WriteLine("Ваш второй массив: " + string.Join("-", secondArr));

            ArraySwaping(ref firstArr, ref secondArr);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ваш массив в стрингах: " + string.Concat(stringArr));
            Console.WriteLine("Ваш интовый массив: " + string.Join("-", firstArr));

            MyArray.MyResize(ref stringArr, 2);
            MyArray.MyResize(ref firstArr, 10);

            Console.WriteLine("Ваш массив в стрингах после обрезания: " + string.Concat(stringArr));
            Console.WriteLine("Ваш бОльший интовый массив: " + string.Join("-", firstArr));

        }
    }
}
