using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Management_System_Version3.Model;

public class Drug
{
    [StringLength(100)]
    public string TradeName { get; set; }

    public string Formula { get; set; }

    [StringLength(100)]
    public string CompanyName { get; set; }

    public PharmaceuticalCompany Company { get; set; }

    public ICollection<PharmacyDrug> PharmacyDrugs { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; }
}