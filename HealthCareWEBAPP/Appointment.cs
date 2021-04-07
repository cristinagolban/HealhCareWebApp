using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCareWEBAPP
{
    public class Appointment
    {
        Doctor doctor { get; set; }

        Pacient pacient { get; set; }

        string simptoms { get; set; }

        DateTime date { get; set; }

        public Appointment(Doctor doctor, Pacient pacient)
        {
                
        }

        

    }
}
