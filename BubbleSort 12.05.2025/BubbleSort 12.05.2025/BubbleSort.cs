using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_12._05._2025
{
    internal class BubbleSort
    {

       public static void Sort<T>(T[] a) where T: IComparable<T>
        {
            bool swapped;
            do 
            {
                swapped = false;
                for(int i=0; i < a.Length - 1; i++)
                {
                    if(Less(a[i], a[i+1]))
                    {
                        Swap(a, i, i+1);
                        swapped = true;
                    }
                }
            } 
            while (swapped);
        }


        public static bool Less<T>(T first, T second) where T : IComparable<T>
        {
            return first.CompareTo(second) > 0;
        }

        public static void Swap<T>(T[] a, int i, int j) where T : IComparable<T>
        {
            T temp = a[i];
            a[i] = a[j];
            a[j] = temp;

        }

        

        
    }
}
