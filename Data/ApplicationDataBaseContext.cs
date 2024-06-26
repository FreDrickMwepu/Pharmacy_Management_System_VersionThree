using Microsoft.EntityFrameworkCore;
using Pharmacy_Management_System_Version3.Model;


namespace Pharmacy_Management_System_Version3.Data;

public class ApplicationDataBaseContext : DbContext
{
    public ApplicationDataBaseContext(DbContextOptions<ApplicationDataBaseContext> options)
        : base(options)
    {
    }  
    
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<PharmaceuticalCompany> PharmaceuticalCompanies { get; set; }
    public DbSet<Drug> Drugs { get; set; }
    public DbSet<Pharmacy> Pharmacies { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<PharmacyDrug> PharmacyDrugs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>()
            .HasOne(p => p.PrimaryPhysician)
            .WithMany(d => d.Patients)
            .HasForeignKey(p => p.PrimaryPhysicianSSN);

        modelBuilder.Entity<Drug>()
            .HasKey(d => new { d.TradeName, d.CompanyName });

        modelBuilder.Entity<PharmacyDrug>()
            .HasKey(pd => new { pd.PharmacyName, pd.DrugTradeName, pd.CompanyName });

        modelBuilder.Entity<Prescription>()
            .HasOne(p => p.Patient)
            .WithMany(pat => pat.Prescriptions)
            .HasForeignKey(p => p.PatientSSN);

        modelBuilder.Entity<Prescription>()
            .HasOne(p => p.Doctor)
            .WithMany(d => d.Prescriptions)
            .HasForeignKey(p => p.DoctorSSN);

        modelBuilder.Entity<Prescription>()
            .HasOne(p => p.Drug)
            .WithMany(d => d.Prescriptions)
            .HasForeignKey(p => new { p.DrugTradeName, p.CompanyName });

        modelBuilder.Entity<Contract>()
            .HasOne(c => c.Company)
            .WithMany(pc => pc.Contracts)
            .HasForeignKey(c => c.CompanyName);

        modelBuilder.Entity<Contract>()
            .HasOne(c => c.Pharmacy)
            .WithMany(ph => ph.Contracts)
            .HasForeignKey(c => c.PharmacyName);

        modelBuilder.Entity<Contract>()
            .HasOne(c => c.Supervisor)
            .WithMany(d => d.Contracts)
            .HasForeignKey(c => c.SupervisorSSN);
    }
}