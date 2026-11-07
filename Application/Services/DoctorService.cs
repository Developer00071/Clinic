using System.Net;
using Application.Interfaces;
using Application.Responses;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class DoctorsService(IDoctorsRepository DoctorsRepository) : IDoctorsService
{
    private IDoctorsRepository repository = DoctorsRepository;
    public async Task<ApiResponse<bool>> AddDoctor(Doctors Doctors)
    {
        var res = await repository.AddDoctor(Doctors);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Added!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not added.", res);
    }

    public async Task<ApiResponse<bool>> DeleteDoctor(int id)
    {
        var res = await repository.DeleteDoctor(id);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Deleted!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not deleted.", res);
    }

    public async Task<ApiResponse<Doctors>> GetDoctor(int id)
    {
        var res = await repository.GetDoctor(id);
        return res!=null
        ? new ApiResponse<Doctors>(HttpStatusCode.OK, "Doctors with given id.", res)
        : new ApiResponse<Doctors>(HttpStatusCode.NotFound, "No Doctors with given id.", res!);
    }

    public async Task<ApiResponse<List<Doctors>>> GetDoctors()
    {
        var res = await repository.GetDoctors();
        return new ApiResponse<List<Doctors>>(HttpStatusCode.OK, "List of Doctorss.", res);
    }

    public async Task<ApiResponse<bool>> UpdateDoctor(Doctors Doctors)
    {
        var res = await repository.UpdateDoctor(Doctors);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Updated!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not updated.", res);
    }

}
