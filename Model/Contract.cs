using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Management_System_Version3.Model;

public class Contract
{
    [Key]
    public int ContractID { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    [StringLength(100)]
    public string Text { get; set; }

    [StringLength(100)]
    public string CompanyName { get; set; }

    public PharmaceuticalCompany Company { get; set; }

    [StringLength(100)]
    public string PharmacyName { get; set; }

    public Pharmacy Pharmacy { get; set; }

    [StringLength(9)]
    public string SupervisorSSN { get; set; }

    public Doctor Supervisor { get; set; }
    
}