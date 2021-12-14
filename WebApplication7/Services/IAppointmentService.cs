using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models.ViewModels;

namespace WebApplication7.Services
{
    public interface IAppointmentService
    {
        public List<DoctorVM> GetDoctorList();

        public List<PatientVM> GetPatientList();
    }
}
