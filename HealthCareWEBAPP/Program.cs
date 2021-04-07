namespace HealthCareWEBAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor ("Virgil Mustata","ORL" );

            Pacient pacient = new Pacient("Golban Cristina");

            Appointment appointment = new Appointment(doctor, pacient);

        }
    }
}
