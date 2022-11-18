using System;
using System.Collections.Generic;

namespace EntityFrameWorkeg.Models
{
    public partial class DoctorInfo
    {
        public int DocId { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Specialization { get; set; } = null!;
        public TimeSpan Shiftstart { get; set; }
        public TimeSpan Shiftend { get; set; }
    }
}
