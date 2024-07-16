namespace IClinicBot.Domain.Entities
{
    public class Patient : Person
    {
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }

        public ICollection<MedicalExam> MedicalExamCollectiom { get; set; }
        public ICollection<Scheduling> SchedulingCollectiom { get; set; }

        public Patient(decimal weight, decimal height, int age)
        {
            Weight = weight;
            Height = height;
            Age = age;
        }
    }
}