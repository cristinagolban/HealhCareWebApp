using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.Domain
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }

        public string Ward { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
