using System;
using System.Collections.Generic;

namespace EntityFrameWorkeg.Models
{
    public partial class Appointment
    {
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? AppointTime { get; set; }

        public virtual DoctorInfo? Doctor { get; set; }
        public virtual PatientInfo? Patient { get; set; }
    }
}
