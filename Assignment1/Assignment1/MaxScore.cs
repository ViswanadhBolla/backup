using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MaxScore
    {
        public int score;
        public void printScore(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Congratulations!!!");
            }
        }
        public void GetScore()
        {
            Console.Write("Enter your maximum score : ");
            this.score = Convert.ToInt32(Console.ReadLine());
            this.printScore(this.score);
        }
    }
}
