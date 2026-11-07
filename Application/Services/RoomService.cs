using System.Net;
using Application.Interfaces;
using Application.Responses;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class RoomsService(IRoomsRepository RoomsRepository) : IRoomsService
{
    private IRoomsRepository repository = RoomsRepository;
    public async Task<ApiResponse<bool>> AddRoom(Rooms Rooms)
    {
        var res = await repository.AddRoom(Rooms);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Added!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not added.", res);
    }

    public async Task<ApiResponse<bool>> DeleteRoom(int id)
    {
        var res = await repository.DeleteRoom(id);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Deleted!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not deleted.", res);
    }

    public async Task<ApiResponse<Rooms>> GetRoom(int id)
    {
        var res = await repository.GetRoom(id);
        return res!=null
        ? new ApiResponse<Rooms>(HttpStatusCode.OK, "Rooms with given id.", res)
        : new ApiResponse<Rooms>(HttpStatusCode.NotFound, "No Rooms with given id.", res!);
    }

    public async Task<ApiResponse<List<Rooms>>> GetRooms()
    {
        var res = await repository.GetRooms();
        return new ApiResponse<List<Rooms>>(HttpStatusCode.OK, "List of Roomss.", res);
    }

    public async Task<ApiResponse<bool>> UpdateRoom(Rooms Rooms)
    {
        var res = await repository.UpdateRoom(Rooms);
        return res==true
        ? new ApiResponse<bool>(HttpStatusCode.OK, "Updated!", res)
        : new ApiResponse<bool>(HttpStatusCode.InternalServerError, "Not updated.", res);
    }

}
