using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RefOutResize
{
    internal class MyArray
    {
        public static void MyResize<T>(ref T[] array, int size)
        {
            T[] newArray = new T[size];
          

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }
}
