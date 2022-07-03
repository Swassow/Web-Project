using System.ComponentModel.DataAnnotations;

namespace logindemo.Models
{
    public class travelData
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string placeName { get; set; }
        [Required]
        public int audults { get; set; }

        public int child { get; set; }
        [Required]
        public int amount { get; set; }
        [Required]
        public int days { get; set; }
        [Required]
        public int night { get; set; }


    }
}
