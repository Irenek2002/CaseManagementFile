using CaseManagementFile.Implementations;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Models;
using SharedLibrary.PatientRepositories;
namespace CaseManagementFile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
            private readonly IPatientRepository PatientRepository;
            public PatientController(IPatientRepository PatientRepository)
            {
                this.PatientRepository = PatientRepository;
            }

            [HttpGet("All-Patients")]
            public async Task<ActionResult<List<Patient>>> GetAllPatientAsync()
            {
                var Patients = await PatientRepository.GetAllPatientsAsync();
                return Ok(Patients);
            }

            [HttpGet("Single-Patient/{id}")]
            public async Task<ActionResult<List<Patient>>> GetSinglePatientAsync(int id)
            {
                var Patient = await PatientRepository.GetPatientByIdAsync(id);
                return Ok(Patient);
            }

            [HttpGet("Add-Patient")]
            public async Task<ActionResult<List<Patient>>> AddPatientAsync(Patient model)
            {
                var Patient = await PatientRepository.AddPatientAsync(model);
                return Ok(Patient);
            }

            [HttpGet("Update-Patient")]
            public async Task<ActionResult<List<Patient>>> UpdatePatientAsync(Patient model)
            {
                var Patient = await PatientRepository.UpdatePatientAsync(model);
                return Ok(Patient);
            }

            [HttpGet("Delete-Patient/{id}")]
            public async Task<ActionResult<List<Patient>>> DeletePatientAsync(int id)
            {
                var Patient = await PatientRepository.DeletePatientAsync(id);
                return Ok(Patient);
            }
        }
}