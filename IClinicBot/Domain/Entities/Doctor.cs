namespace IClinicBot.Domain.Entities
{
    public class Doctor : Person
    {
        public string CRM { get; set; }

        public ICollection<MedicalExam> MedicalExamCollectiom { get; set; }
        public ICollection<Scheduling> SchedulingCollectiom { get; set; }

        public Doctor(string cRM)
        {
            CRM = cRM;
        }
    }
}