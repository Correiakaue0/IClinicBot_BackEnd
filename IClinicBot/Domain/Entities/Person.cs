namespace IClinicBot.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Person() { }

        public Person(int id, string fullName, string cPF, string email, string password, DateTime registrationDate)
        {
            Id = id;
            FullName = fullName;
            CPF = cPF;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
        }
    }
}