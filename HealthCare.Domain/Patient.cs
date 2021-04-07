using System.Collections.Generic;

namespace HealthCare.Domain
{
    public class Patient : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
