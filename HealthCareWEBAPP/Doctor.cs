using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCareWEBAPP
{
    public class Doctor
    {
        string Name { get; set; }

        string Ward { get; set; }

        List<Appointment> appointments { get; set; }

        List<Pacient> pacients { get; set; }

        public Doctor()
        {

        }

        public Doctor(string Name, string Ward)
        {
            this.Name = Name;

            this.Ward = Ward;

        }

       


    }
}
