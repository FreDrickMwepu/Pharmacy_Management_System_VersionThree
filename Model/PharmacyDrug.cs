using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Management_System_Version3.Model;

public class PharmacyDrug
{
    [StringLength(100)]
    public string PharmacyName { get; set; }

    public Pharmacy Pharmacy { get; set; }

    [StringLength(100)]
    public string DrugTradeName { get; set; }

    [StringLength(100)]
    public string CompanyName { get; set; }

    public Drug Drug { get; set; }

    public decimal Price { get; set; }
}