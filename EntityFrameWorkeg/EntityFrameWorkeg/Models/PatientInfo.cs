using System;
using System.Collections.Generic;

namespace EntityFrameWorkeg.Models
{
    public partial class PatientInfo
    {
        public int PatientId { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public DateTime Dob { get; set; }
    }
}
