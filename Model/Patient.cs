using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy_Management_System_Version3.Model;

public class Patient
{
    [Key]
    [StringLength(9)]
    public string SSN { get; set; }

    [StringLength(100)]
    public string FirstName { get; set; }
    
    [StringLength(100)]
    public string LastName { get; set; }

    [StringLength(200)]
    public string Address { get; set; }

    public int Age { get; set; }

    [StringLength(9)]
    public string PrimaryPhysicianSSN { get; set; }

    public Doctor PrimaryPhysician { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; }
    
    [NotMapped]
    public string Name => $"{FirstName} {LastName}";
    
}