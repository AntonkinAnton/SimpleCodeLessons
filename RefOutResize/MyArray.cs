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
        public static void Resize<T>(ref T[] array, int size)
        {
            T[] newArray = new T[size];
          

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        public static void AddByIndex<T>(ref T[] array, T value, int index)
        {
            T[] newArray = new T[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;
        }

        public static void AddFirst<T>(ref T[] array, T value)
        {
            AddByIndex(ref array, value, 0);
        }

        public static void AddLast<T>(ref T[] array, T value)
        {
            AddByIndex(ref array, value, array.Length);
        }

        public static void RemoveByIndex<T>(ref T[] array, int index)
        {
            T[] newArray = new T[array.Length-1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
        }

        public static void RemoveFirst<T>(ref T[] array)
        {
            RemoveByIndex(ref array, 0);
        }
        public static void RemoveLast<T>(ref T[] array)
        {
            RemoveByIndex(ref array, array.Length - 1);
        }
    }
}
