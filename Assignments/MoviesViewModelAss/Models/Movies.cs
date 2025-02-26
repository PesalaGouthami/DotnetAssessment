using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesViewModelAss.Models
{
    [Table("movies")]
    public class Movies
    {
        [Key]
        public string name { get; set; }
        public string genre {  get; set; }
        public int year {  get; set; }
        public string producer {  get; set; }
    }
}
