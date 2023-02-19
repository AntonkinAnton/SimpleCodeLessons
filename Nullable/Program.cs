
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
            array ??= new string [1] {" ну типа нул референс ваш тут..."};
            Console.WriteLine(string.Join("разделительбля", array));
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
                choose = MyMethods.GetNum("1 - словить NullReferenceException\n2 - если Null, то создать и зарандомить массив" +
                    "\n3 - закрыть программу и спокойно пойти пить чай");
            } while (choose != 1 && choose != 2 && choose != 3);
           
            switch (choose)
            {
                case 1:
                    
                    NullableArrayError(array);
                    break;
                case 2:
                    arrayInt = MakeArrayNull();                   
                    int cases = (arrayInt?.Length ?? MyMethods.FillArrayRndmReturn(arrayInt = MyMethods.CreateArray(3)).Length);
                    MyMethods.PrintArray(arrayInt, "Ваш обновленный массив после Null:");
                    MyMethods.EndMessage("Жмите кнопку и Дотвидания!!!", 30);
                    break;
                case 3:
                    MyMethods.RunningString("Приятного чаепития!!", 70);
                    break;
            }
            
            MyMethods.End();

        }
    }
}
