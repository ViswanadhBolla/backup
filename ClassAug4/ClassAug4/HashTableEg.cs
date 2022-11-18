using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAug4
{
    internal class HashTableEg
    {
        public static void Main(string[] args)
        {
            #region
            //Hashtable ht = new Hashtable();
            //ht.Add("1001", "TCS");
            //ht.Add("1002", null);
            //ht.Add("1003", "Infy");
            //ht.Add("1004", "Eurofins");

            //foreach(var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------");

            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------------------------");

            //foreach (DictionaryEntry de in ht)
            //{
            //    Console.WriteLine(de.Key+" "+de.Value);
            //}
            //Console.WriteLine("------------------------");

            //Console.WriteLine("Enter the key to be searched");
            //string search = Console.ReadLine();
            //if (ht.ContainsKey(search))
            //{
            //    Console.WriteLine(ht[search]);
            //}



            //Hashtable emps = new Hashtable();
            //emps.Add("1001", new Emp(1, "Ram"));
            //emps.Add("1002", new Emp(2, "Ravi"));

            //foreach(var item in emps.Values)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine("----------------------------");
            //emps["1002"] = new Emp(3, "Raju");
            //foreach (var item in emps.Values)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            #endregion


            ArrayList AL = new ArrayList();            
            AL.Add(1);
            AL.Add(2);
            AL.Add(3);

            Hashtable HT = new Hashtable();
            HT.Add("1001", AL);

            foreach(ArrayList item in HT.Values)
            {
                foreach(var value in item)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
