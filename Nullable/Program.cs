
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static int[] MakeArrayNull()
        {
            return null;
        }
       
        static void NullableArrayError(string[] array)
        {
            array = null;
            array ??= new string [1] {"Ну типа нул референс ваш тут...\n"};
            Console.WriteLine(string.Join("разделительбля", array));
            MyMethods.EndMessageFromStart("Ну типа всё...", 20);
        }
        static void Main(string[] args)
        {
            string[] array = { "1", "2", "3" };
            int choose;
            int[] arrayInt = { 1, 2, 3 };

            do
            {
                Console.Clear();
                Console.WriteLine("Choose youe destiny:");
                choose = MyMethods.GetNum("1 - словить NullReferenceException\n" +
                    "2 - если Null, то создать и зарандомить массив\n" +
                    "3 - закрыть программу и спокойно пойти пить чай\n" +
                    "4 - посмотреть на цветные букаффки");
            } while (choose < 1 || choose > 4); 
           
            switch (choose)
            {
                case 1:
                    NullableArrayError(array);
                    break;
                case 2:
                    arrayInt = MakeArrayNull();                   
                    int cases = arrayInt?.Length ?? MyMethods.FillArrayRndmReturn(arrayInt = MyMethods.CreateArray(3)).Length;
                    MyMethods.PrintArray(arrayInt, "Ваш обновленный массив после Null:");
                    MyMethods.EndMessageFromMiddle("Жмите кнопку и Дотвидания!!!", 30);
                    break;
                case 3:
                    MyMethods.RunningString("Приятного чаепития!!");
                    break;
                case 4:
                    MyMethods.EndMessageColoredLetters("Спасибо, что выбрал этот пункт!!");
                    break;
            }
            
            MyMethods.End();

        }
    }
}
