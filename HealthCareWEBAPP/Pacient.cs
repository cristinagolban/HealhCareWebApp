using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCareWEBAPP
{
    public class Pacient
    {
        string Name { get; set; }

        List<Appointment> appointments { get; set; }

        List<Doctor> doctors { get; set; }

        public Pacient(string Name)
        {
            this.Name = Name;

        }
    }
}
