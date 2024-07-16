using IClinicBot.Domain.Interfaces.Service;
using IClinicBot.Domain.ReturnViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IClinicBot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService) 
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public ActionResult<List<DoctorReturnViewModel>> GetAll()
        {
            return Ok(_doctorService.GetAll());
        }
    }
}
