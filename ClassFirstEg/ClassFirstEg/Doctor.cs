using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassFirstEg
{
    public class Doctor
    {
        [Key]

        public int DocId { get; set; }
        public string DocName { get; set; }
        public string Spcialization { get; set; }

        
    }
}
