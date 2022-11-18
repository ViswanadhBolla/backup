using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassFirstEg
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        public string PatientName { get; set; }

        public Doctor doctor { get; set; }


    }
}
