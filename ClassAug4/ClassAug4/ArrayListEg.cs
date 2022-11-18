using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassAug4
{
    internal class ArrayListEg
    {
        public static void main(string[] args)
        {
            #region
            //int[] a = new int[5] ;
            //Console.WriteLine("Enter the numbers : ");
            //for (int i = 0 ; i < a.Length ; i++)
            //{
            //    a[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Console.WriteLine("Elements are : ");
            //for(int i = 0 ; i < a.Length ; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            #endregion
            ArrayList al = new ArrayList();
            al.Add(4);
            al.Add("Ram");
            al.Add(false);
            al.Add(34.45f);
            al.Insert(2, 80);

            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
            al.Remove(false);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
