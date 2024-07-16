using IClinicBot.Domain.Interfaces.Repository;
using IClinicBot.Domain.Interfaces.Service;
using IClinicBot.Domain.ReturnViewModel;

namespace IClinicBot.Service.Services
{
    public class DoctorService : IDoctorService
    {
        private IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public List<DoctorReturnViewModel> GetAll()
        {
            return (from i in _doctorRepository.GetAll()
                    select new DoctorReturnViewModel
                    {

                    }).ToList();
        }
    }
}