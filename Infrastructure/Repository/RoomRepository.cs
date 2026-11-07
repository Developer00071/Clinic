using Dapper;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class RoomsRepository(AppDbConection _AppDbConection) : IRoomsRepository
{
    private AppDbConection _AppDbConection = _AppDbConection;

   
    public async Task<bool> AddRoom(Rooms Rooms)
    {
        var connection = _AppDbConection.Connection();
        var query = "insert into Roomss(fullname, country, birthyear) values(@fullname, @country, @birthyear)";
        var res = await connection.ExecuteAsync(query, Rooms);
        return res>0;
    }


    public async Task<bool> DeleteRoom(int id)
    {
        var connection = _AppDbConection.Connection();
        var query = "delete from Roomss where id=@id";
        var res = await connection.ExecuteAsync(query, new{id});
        return res>0;
    }

    


    public async Task<Rooms> GetRoom(int id)
    {
        var connection = _AppDbConection.Connection();
        var query = "select * from Roomss where id=@id";
        var res = await connection.QuerySingleOrDefaultAsync<Rooms>(query, new{id});
        return res!;
    }

    


    public async Task<List<Rooms>> GetRooms()
    {
        var connection = _AppDbConection.Connection();
        var query = "select * from Roomss";
        var res = await connection.QueryAsync<Rooms>(query);
        return res.ToList();    
    }

   


    public async Task<bool> UpdateRoom(Rooms Rooms)
    {
        var connection = _AppDbConection.Connection();
        var query = "update Roomss set fullname=@fullname, country=@country, birthyear=@birthyear where id=@id";
        var res = await connection.ExecuteAsync(query, Rooms);
        return res>0;
    }
}
