using System.ComponentModel.DataAnnotations;

namespace CoreAracKiralama.Models
{
    public class Kampanyalar
    {
        [Key]
        public int KampanyaNo { get; set; }

        [Required]
        [StringLength(100)]
        public string Kampanya { get; set; }

    }
       
}
