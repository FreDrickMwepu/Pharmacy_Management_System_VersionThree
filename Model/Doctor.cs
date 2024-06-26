using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy_Management_System_Version3.Model;

public class Doctor : BaseModel
{
    [Key]
    [StringLength(9)]
    public int SSN { get; set; }
    [StringLength(100)]
    public string FirstName { get; set; }
    [StringLength(100)]
    public string LastName { get; set; }
    [StringLength(100)]
    public string Specialty { get; set; }
    public ICollection<Patient> Patients { get; set; }
    public ICollection<Contract> Contracts { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; }
    
    [NotMapped]
    public string Name => $"{FirstName} {LastName}";
}