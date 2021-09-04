using System;
using System.Text;
using System.Collections.Generic;

namespace Library
{
    public class AppointmentService
    {
        public static List<Appointment> appointments = new List<Appointment>();

        public static void CreateAppointment(Appointment appointment)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(appointment.Patient.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.Patient.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.AppointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(appointment.Doctor.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            appointments.Add(appointment);
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
