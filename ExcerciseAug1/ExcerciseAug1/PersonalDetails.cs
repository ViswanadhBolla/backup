using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseAug1
{
    internal class PersonalDetails
    {
        int StuID;
        DateOnly DOB;
        string BloodGroup;
        string PhoneNO;

        

        public PersonalDetails(int stuID, DateOnly dOB, string bloodGroup, string phoneNO)
        {
            StuID=stuID;
            DOB=dOB;
            BloodGroup=bloodGroup;
            PhoneNO=phoneNO;

        }
        public void setValues()
        {
            Console.Write("Enter Student ID : ");
            StuID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Date of Birth : ");
            DOB = DateOnly.Parse(Console.ReadLine());
            Console.Write("Enter blood Group: ");
            BloodGroup = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            PhoneNO = Console.ReadLine();
        }
    }
}
