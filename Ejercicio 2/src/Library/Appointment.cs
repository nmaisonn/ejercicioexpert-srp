using System;

namespace Library
{
    public class Appointment
    {
        public string Id;
        public DateTime Date;
        public string AppointmentPlace;
        public Patient Patient;
        public Doctor Doctor;

        public Appointment(string id, DateTime date, string appointmentPlace, Patient patient, Doctor doctor)
        {
            this.Id = id;
            this.Date = date;
            this.AppointmentPlace = appointmentPlace;
            this.Patient = patient;
            this.Doctor = doctor;
        }
    }
}