using System.Net;
using Application.Interfaces;
using Application.Responses;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class PatientsService(IPatientsRepository PatientsRepository) : IPatientsService
{
    private IPatientsRepository repository = PatientsRepository;
    public async Task<ApiResponse<bool>> AddPatient(Patients Patients)
    {
        var res = await repository.AddPatient(Patients);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Added!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not added.", res);
    }

    public async Task<ApiResponse<bool>> DeletePatient(int id)
    {
        var res = await repository.DeletePatient(id);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Deleted!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not deleted.", res);
    }

    public async Task<ApiResponse<Patients>> GetPatient(int id)
    {
        var res = await repository.GetPatient(id);
        return res!=null
        ? new ApiResponse<Patients>(HttpStatusCode.OK, "Patients with given id.", res)
        : new ApiResponse<Patients>(HttpStatusCode.NotFound, "No Patients with given id.", res!);
    }

    public async Task<ApiResponse<List<Patients>>> GetPatients()
    {
        var res = await repository.GetPatients();
        return new ApiResponse<List<Patients>>(HttpStatusCode.OK, "List of Patientss.", res);
    }

    public async Task<ApiResponse<bool>> UpdatePatient(Patients Patients)
    {
        var res = await repository.UpdatePatient(Patients);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Updated!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not updated.", res);
    }

}
