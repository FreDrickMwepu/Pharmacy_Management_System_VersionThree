using System.ComponentModel.DataAnnotations;

namespace Pharmacy_Management_System_Version3.Model;

public class Prescription
{
    [Key]
    public int PrescriptionID { get; set; }

    public DateTime Date { get; set; }

    public int Quantity { get; set; }

    [StringLength(9)]
    public string PatientSSN { get; set; }

    public Patient Patient { get; set; }

    [StringLength(9)]
    public string DoctorSSN { get; set; }

    public Doctor Doctor { get; set; }

    [StringLength(100)]
    public string DrugTradeName { get; set; }

    [StringLength(100)]
    public string CompanyName { get; set; }

    public Drug Drug { get; set; }
}