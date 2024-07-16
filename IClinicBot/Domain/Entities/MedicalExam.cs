using Domain.Enums;

namespace IClinicBot.Domain.Entities
{
    public class MedicalExam
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public EnumExamType ExamType { get; set; }
        public string Observation { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public MedicalExam(int id, DateTime date, EnumExamType examType, string observation, int doctorId, int patientId, Doctor doctor, Patient patient)
        {
            Id = id;
            Date = date;
            ExamType = examType;
            Observation = observation;
            DoctorId = doctorId;
            PatientId = patientId;
            Doctor = doctor;
            Patient = patient;
        }
    }
}