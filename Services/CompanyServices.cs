using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Data;
using Pharmacy_Management_System_Version3.Model; // Correct namespace for the model

namespace Pharmacy_Management_System_Version3.Services
{
    public class CompanyServices
    {
        private readonly ApplicationDataBaseContext _dbContext;

        public CompanyServices(ApplicationDataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PharmaceuticalCompany>> Get()
        {
            return await _dbContext.PharmaceuticalCompanies.ToListAsync();
        }

        public async Task Post(PharmaceuticalCompany company)
        {
            await _dbContext.PharmaceuticalCompanies.AddAsync(company);
            await _dbContext.SaveChangesAsync();
        }
    }
}