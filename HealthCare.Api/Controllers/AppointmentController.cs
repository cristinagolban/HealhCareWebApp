using HealthCare.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace HealthCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        private static List<Appointment> _appointments = new List<Appointment>()
        {
            new Appointment {
                Id = Guid.NewGuid(),
                Time = DateTime.Now,
                Doctor = new Doctor
                {
                    Name = "Doctor 1",
                    Ward = "Ward 1",
                } ,
                Patient = new Patient
                {
                    Name = "Patient 1",
                }
            },

             new Appointment {
                Id = Guid.NewGuid(),
                Time = DateTime.Now,
                Doctor = new Doctor
                {
                    Name = "Doctor 2",
                    Ward = "Ward 2",
                } ,
                Patient = new Patient
                {
                    Name = "Patient 2",
                }
            }


        };

        public AppointmentController()
        {
        }

        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_appointments);
        }

        [HttpPost]
        public IActionResult CreateAppointment([FromBody] Appointment appointment)
        {
            _appointments.Add(appointment);

            return Ok();
        }

        [HttpDelete]
        [Route("{appointmentId}")]
        public IActionResult DeleteAppointment(Guid appointmentId)
        {
            var toDelete = _appointments.SingleOrDefault(a => a.Id == appointmentId);

            if(toDelete == null)
            {
                return BadRequest("No appointment with given Id could be found");
            }

            _appointments.Remove(toDelete);

            return Ok();
        }

    }
}
