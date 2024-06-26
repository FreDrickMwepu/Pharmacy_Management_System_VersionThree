using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Data;
using Pharmacy_Management_System_Version3.Model;

namespace Pharmacy_Management_System_Version3.Services
{
    public class PrescriptionServices
    {
        private readonly ApplicationDataBaseContext _dbContext;

        public PrescriptionServices(ApplicationDataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Prescription>> Get()
        {
            return await _dbContext.Prescriptions.ToListAsync();
        }

        public async Task Post(Prescription prescription)
        {
            await _dbContext.Prescriptions.AddAsync(prescription);
            await _dbContext.SaveChangesAsync();
        }
    }
}