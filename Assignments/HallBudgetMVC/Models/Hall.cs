using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HallBudgetMVC.Models
{
    [Table("hall")]
    public class Hall
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hall_name")]
        public string HallName { get; set; }
        [Column("owner_name")]
        public string OwnerName {  get; set; }
        [Column("cost_per_day")]
        public int CostPerDay {  get; set; }
        [Column("mobile")]
        public string Mobile {  get; set; }
        [Column("address")]
        public string Address {  get; set; }
    }
}
