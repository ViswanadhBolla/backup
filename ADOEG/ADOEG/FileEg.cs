using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOEG
{
    internal class FileEg
    {
        public static void Main()
        {
            FileStream fs = new FileStream("C://Users//Admin//Desktop//repos//ADOEG//ADOEG//message.txt", FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            sw.WriteLine(name + " " + DateTime.Now);
            sw.Flush();
            fs.Close();
        }
    }
}
