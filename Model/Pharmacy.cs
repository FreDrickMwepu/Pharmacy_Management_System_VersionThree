using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Management_System_Version3.Model;

public class Pharmacy
{
    [Key]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(200)]
    public string Address { get; set; }

    [StringLength(15)]
    public string PhoneNumber { get; set; }

    public ICollection<Contract> Contracts { get; set; }
    public ICollection<PharmacyDrug> PharmacyDrugs { get; set; }
}