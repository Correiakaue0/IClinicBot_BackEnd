using IClinicBot.Domain.ReturnViewModel;

namespace IClinicBot.Domain.Interfaces.Service
{
    public interface IDoctorService 
    {
        List<DoctorReturnViewModel> GetAll();
    }
}