using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RentCalculationMVC.Models
{
    public class User
    {
        [StringLength(10)]
        [Required(ErrorMessage ="Name field is mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Owner Name field is mandatory")]
        public string HallOwner { get; set; }
        [Required(ErrorMessage = "Cost field is mandatory")]
        public int Cost { get; set; }
        [Required(ErrorMessage = "Start Date field is mandatory")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End Date field is mandatory")]
        public DateTime EndDate { get; set; }
        public int rent {  get; set; }
    }
}
