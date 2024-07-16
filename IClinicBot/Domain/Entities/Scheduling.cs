using Domain.Enums;

namespace IClinicBot.Domain.Entities
{
    public class Scheduling
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public EnumStatusScheduling StatusScheduling { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public Scheduling(int id, DateTime date, EnumStatusScheduling statusScheduling, int doctorId, int patientId, Doctor doctor, Patient patient)
        {
            Id = id;
            Date = date;
            StatusScheduling = statusScheduling;
            DoctorId = doctorId;
            PatientId = patientId;
            Doctor = doctor;
            Patient = patient;
        }
    }
}