using Application.Interfaces;
using Application.Responses;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientsController(ILogger<PatientsController> logger , IPatientsService PatientService): ControllerBase
{
    private IPatientsService service = PatientService;
    private readonly ILogger<PatientsController> _logger;
    [HttpPost]
    public async Task<ApiResponse<bool>> AddPatient(Patients Patient)
    {
     _logger.LogInformation($"{Patient} added sucsesfuly at {DateTime.Now}");
        return await service.AddPatient(Patient);
    }
    
    [HttpPut]
    public async Task<ApiResponse<bool>> UpdatePatient(Patients Patient)
    {
        _logger.LogInformation($"{Patient} updated sucsesfuly at {DateTime.Now}");
        return await service.UpdatePatient(Patient);
    }
    
    [HttpDelete]
    public async Task<ApiResponse<bool>> DeletePatient(int id)
    {
                _logger.LogInformation($"Patient with id {id} deleted sucsesfuly at {DateTime.Now}");

        return await service.DeletePatient(id);
    }

    [HttpGet("{id:int}")]
    public async Task<ApiResponse<Patients>> GetPatient(int id)
    {
        _logger.LogInformation($"get Patient with id {id} at {DateTime.Now}");
        return await service.GetPatient(id);
    }
    
    [HttpGet]
    public async Task<ApiResponse<List<Patients>>> GetPatients()
    {
                _logger.LogInformation($"all Patients was get at {DateTime.Now}");

        return await service.GetPatients();
    }
}
