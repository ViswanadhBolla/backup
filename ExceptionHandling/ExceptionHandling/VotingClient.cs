using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class AgeNotValidException : ApplicationException
    {
        public AgeNotValidException(string message) : base(message) { }
    }

    public class voting
    {
        public int Age { get; set; }
        public void checkAge()
        {
            Console.WriteLine("Enter Age :");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 18)
            {
                
                throw new AgeNotValidException("Sorry! you are not elligible to vote");
            }
            else
            {
                Console.WriteLine("Thanks for voting");
                
            }
        }
    }
    internal class VotingClient
    {
        public static void main()
        {
            voting v = new voting();
            try
            {
                v.checkAge();
            }
            catch (AgeNotValidException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
