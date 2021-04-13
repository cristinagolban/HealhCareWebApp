using System;

namespace HealthCare.Domain
{
    public class Appointment : BaseEntity
    {
        public DateTime Time { get; set; }


        public Doctor Doctor { get; set; }


        public Patient Patient { get; set; }
    }
}
