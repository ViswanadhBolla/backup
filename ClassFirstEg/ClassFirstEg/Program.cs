using Microsoft.EntityFrameworkCore;

namespace ClassFirstEg
{
    class Program
    {
        public static Doctor doc = new Doctor();
        public static Patient patient = new Patient();

        static void Main(string[] args)
        {
            addDoctor();
            DisplayDetails();

        }

        private static void addDoctor()
        {
            
            using(var db = new HospitalContext())
            {
                var result = db.Patients.Include(x => x.doctor);
                Console.WriteLine("Enter ,DocName,Spcialization");
                doc.DocName = Console.ReadLine();
                doc.Spcialization = Console.ReadLine();
                db.Doctors.Add(doc);
                db.SaveChanges();
            }
        }

        private static void DisplayDetails()
        {
            using (var db = new HospitalContext())
            {
                foreach (var item in db.Doctors)
                {
                    Console.WriteLine(item.DocId + " " + item.DocName + " " + item.Spcialization);
                }
            }
        }
    }
}