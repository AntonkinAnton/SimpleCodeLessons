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
            //int[] arrTemp = arra1;
            (arra1, arra2) = (arra2, arra1);
            
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

            MyArray.Resize(ref stringArr, 2);
            MyArray.Resize(ref firstArr, 10);

            Console.WriteLine("Ваш массив в стрингах после обрезания: " + string.Concat(stringArr));
            Console.WriteLine("Ваш бОльший интовый массив: " + string.Join("-", firstArr));

            MyArray.AddLast(ref stringArr, "В конец");
            Console.WriteLine("Ваш массив после добавления в конец: " + string.Concat(stringArr));

            MyArray.AddFirst(ref stringArr, "В начало");
            Console.WriteLine("Ваш массив после добавления в начало: " + string.Concat(stringArr));

            MyArray.AddByIndex(ref stringArr, "В середину - третьим", 2);
            Console.WriteLine("Ваш массив после добавления в середину третьим: " + string.Concat(stringArr));

            MyArray.RemoveByIndex(ref stringArr, 2);
            Console.WriteLine("Ваш массив после удаления третьего элемента: " + string.Concat(stringArr));

            MyArray.RemoveLast(ref stringArr);
            Console.WriteLine("Ваш массив после удаления последнего элемента: " + string.Concat(stringArr));

            MyArray.RemoveFirst(ref stringArr);
            Console.WriteLine("Ваш массив после удаления первого элемента: " + string.Concat(stringArr));
            Console.WriteLine();
            MyMethods.ArrayIndexer(firstArr);
        }
    }
}
