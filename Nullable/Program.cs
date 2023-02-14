
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void NullableArrayError(string[] array)
        {
            array[0] = null;
            string kindOfNull = array[0] ?? "ну типа нул референс ваш тут...";
            Console.WriteLine(kindOfNull);
        }
        static void Main(string[] args)
        {
            string[] array = { "1", "2", "3" };
            int choose;

            do
            {
                Console.Clear();
                Console.WriteLine("Choose youe destiny:");
                choose = MyMethods.GetNum("1 - словить NullReferenceException\n2 - закрыть программу и спокойно пойти пить чай");
            } while (choose != 1 && choose != 2);
           
            switch (choose)
            {
                case 1:
                    NullableArrayError(array);
                    break;
                case 2:
                    MyMethods.RunningString("Приятного чаепития!!", 70);
                    break;
            }

            Console.ReadKey();



        }
    }
}
