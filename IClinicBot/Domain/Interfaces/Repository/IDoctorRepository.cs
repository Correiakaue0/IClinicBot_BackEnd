using IClinicBot.Domain.Entities;

namespace IClinicBot.Domain.Interfaces.Repository
{
    public interface IDoctorRepository
    {
        List<Doctor> GetAll();
    }
}