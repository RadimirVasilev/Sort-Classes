using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSorter
{
    internal class StudentSort
    {

        public static void Sort(Student[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i-1; j++)
                {
                    if (a[j].Grade < a[j + 1].Grade)
                    {
                        Swap(a, j);

                    }
                }
            }
        }
        public static void Swap(Student[] a,int first)
        {

            var swap = a[first];
            a[first] = a[first+1];
            a[first+1] = swap;

        }








    }
}
