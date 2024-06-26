using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Data;
using Pharmacy_Management_System_Version3.Model;

namespace Pharmacy_Management_System_Version3.Services;

public class DoctorServices
{
    private readonly ApplicationDataBaseContext _dbContext;

    public DoctorServices(ApplicationDataBaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Doctor>> Get()
    {
        return await _dbContext.Doctors.ToListAsync();
    }

    public async Task Post(Doctor doctor)
    {
        await _dbContext.Doctors.AddAsync(doctor);
        await _dbContext.SaveChangesAsync();
    }
}