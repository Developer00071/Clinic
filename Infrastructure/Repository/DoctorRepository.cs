using Dapper;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class DoctorsRepository(AppDbConection _AppDbConection) : IDoctorsRepository
{
    private AppDbConection _AppDbConection = _AppDbConection;

   
    public async Task<bool> AddDoctor(Doctors Doctors)
    {
        var connection = _AppDbConection.Connection();
        var query = "insert into Doctors(fullname, country, birthyear) values(@fullname, @country, @birthyear)";
        var res = await connection.ExecuteAsync(query, Doctors);
        return res>0;
    }

    public async Task<bool> DeactivateDoctor(int id)
    {
       var connection = _AppDbConection.Connection();
       var query = "update from doctors set IsActive=false where id = @id";
       var res = await connection.ExecuteAsync(query , new {id});
       return res>0;
    }

    public async Task<bool> DeleteDoctor(int id)
    {
        var connection = _AppDbConection.Connection();
        var query = "delete from Doctors where id=@id";
        var res = await connection.ExecuteAsync(query, new{id});
        return res>0;
    }

    


    public async Task<Doctors> GetDoctor(int id)
    {
        var connection = _AppDbConection.Connection();
        var query = "select * from Doctorss where id=@id";
        var res = await connection.QuerySingleOrDefaultAsync<Doctors>(query, new{id});
        return res!;
    }

    


    public async Task<List<Doctors>> GetDoctors()
    {
        var connection = _AppDbConection.Connection();
        var query = "select * from Doctorss";
        var res = await connection.QueryAsync<Doctors>(query);
        return res.ToList();    
    }

   


    public async Task<bool> UpdateDoctor(Doctors Doctors)
    {
        var connection = _AppDbConection.Connection();
        var query = "update Doctorss set fullname=@fullname, country=@country, birthyear=@birthyear where id=@id";
        var res = await connection.ExecuteAsync(query, Doctors);
        return res>0;
    }
    
}
