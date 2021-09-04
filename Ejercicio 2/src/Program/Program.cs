using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient person1 = new Patient("1.222.333-4", "Carlos Perez", "097111555", 78);
            Doctor doctor1 = new Doctor("9.456.789-8", "Gregory House", "Oncologo");
            Appointment appointment1 = new Appointment("1", new DateTime(2021, 09, 15), "Medica Uruguaya Anexo 11", person1, doctor1);
            AppointmentService.CreateAppointment(appointment1);
        }
    }
}
