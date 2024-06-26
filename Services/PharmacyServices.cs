using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Data;
using Pharmacy_Management_System_Version3.Model;

namespace Pharmacy_Management_System_Version3.Services;

public class PharmacyServices
{
    private readonly ApplicationDataBaseContext _dbContext;

    public PharmacyServices(ApplicationDataBaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Pharmacy>> Get()
    {
        return await _dbContext.Pharmacies.ToListAsync();
    }

    public async Task Post(Pharmacy pharmacy)
    {
        await _dbContext.Pharmacies.AddAsync(pharmacy);
        await _dbContext.SaveChangesAsync();
    }
}