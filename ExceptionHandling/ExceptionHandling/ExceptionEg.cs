using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ExceptionEg
    {
        public static void main(String[] args)
        {
            int c = 0;
            try
            {
                Console.WriteLine("Enter two numbers");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                int[] a1 = new int[2] { 5, 6 };
                
                Console.WriteLine(a1[2]);
                Console.WriteLine(c);
            }
            catch (FormatException f)
            {
                Console.WriteLine("please enter only numbers");
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot be divided by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(c);
            }
        }
    }
}
