namespace CMCS.Models
{
    // ViewModel to represent claim data in UI layer
    public class ClaimViewModel
    {
        public int ClaimID { get; set; }
        public string LecturerName { get; set; }
        public string Month { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        // Automatically calculated total amount based on hours and rate
        public decimal TotalAmount => HoursWorked * HourlyRate;
        public string Status { get; set; }
        // Uploaded supporting document
        public IFormFile SupportingDocument { get; set; }
    }
}
// Troelson, A. and Japikse P., 2022. Pro C# 10 with .NET 6. 11th ed. California: Apress.