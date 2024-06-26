using System.ComponentModel.DataAnnotations;
namespace Pharmacy_Management_System_Version3.Model;

public class PharmaceuticalCompany
{
    [Key]
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(15)]
    public string PhoneNumber { get; set; }

    public ICollection<Drug> Drugs { get; set; }
    public ICollection<Contract> Contracts { get; set; }
}

