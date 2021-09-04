using System;
using System.Text;

namespace Library
/*- En primer lugar no cumple con el principio SRP ya que la clase AppointmentService 
tiene muchas responsabilidades.
 - Cumple con el patron Expert ya que tiene toda la información necesaria para realizar todas las 
 responsabilidades pero estan mal asignadas.
 - Para solucionar este problema se crearian las siguientes clases: 
   - Doctor: Su funcion es conocer los datos del doctor.
   - Paciente: Conocer los datos del paciente.
   - Consulta: Conoce la fecha de la consulta, quien será el doctor y el paciente.
   - ServicioConsulta: Administra las consultas.*/
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
