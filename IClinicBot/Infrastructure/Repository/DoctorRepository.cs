using IClinicBot.Domain.Entities;
using IClinicBot.Domain.Interfaces.Repository;
using Infrastructure.Context;

namespace IClinicBot.Infrastructure.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly Context _context;

        public DoctorRepository(Context context)
        {
            _context = context;
        }

        public List<Doctor> GetAll()
        {
            return _context.Doctor.ToList();
        }
    }
}