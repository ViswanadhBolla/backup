using System;
using EntityFrameWorkeg.Models;

namespace EntityFrameWorkeg
{
    class Program
    {
        //public static clinicContext db = new clinicContext();
        public static UserInfo u = new UserInfo();

        static void Main(string[] args)
        {
            //AddUser();
            //DeleteUser();
            UpdatePassword();
            DisplayDetails();

        }

        private static void AddUser()
        {
            using (var db = new clinicContext())
            {
                Console.WriteLine("Enter username, firstname,lastname,password");
                u.Username = Console.ReadLine();
                u.Firstname = Console.ReadLine();
                u.Lastname = Console.ReadLine();
                u.Userpassword = Console.ReadLine();
                db.UserInfos.Add(u);//insert into dbset of context
                db.SaveChanges();//insert a record into table
            }
        }

        private static void DeleteUser()
        {
            Console.WriteLine("Enter userid");
            string id = Console.ReadLine();
            using (var db = new clinicContext())
            {
                u = db.UserInfos.Find(id);
                db.UserInfos.Remove(u);
                db.SaveChanges();
                Console.WriteLine(u.Username + " is deleted");
            }
        }

        private static void UpdatePassword()
        {
            using(var db = new clinicContext())
            {
                Console.WriteLine("Enter userid");
                string uid = Console.ReadLine();
                u = db.UserInfos.Find(uid);
                Console.WriteLine("Enter new password: ");
                u.Userpassword = Console.ReadLine();
                db.UserInfos.Update(u);
                db.SaveChanges();
                Console.WriteLine("password updated");
            }
        }
        private static void DisplayDetails()
        {
            using (var db = new clinicContext())
            {
                foreach (var item in db.UserInfos)
                {
                    Console.WriteLine(item.Username + " " + item.Firstname + " " + item.Lastname);
                }
            }
        }

        
    }
}