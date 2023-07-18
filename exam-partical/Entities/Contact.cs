using System.ComponentModel.DataAnnotations;

namespace exam_partical.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Contact Name cannot exceed 100 characters.")]
        public string ContactName { get; set; }
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Contact Number must be a 10-digit number.")]
        public string ContactNumber { get; set; }
        public string GroupName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? Birthday { get; set; }
    }

}
