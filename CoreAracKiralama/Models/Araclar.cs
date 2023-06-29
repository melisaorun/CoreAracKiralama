using System.ComponentModel.DataAnnotations;

namespace CoreAracKiralama.Models
{
    public class Araclar
    {
        [Key] 
        public int AracNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Marka { get; set; }
        public string Model { get;set; }
        public string VitesDurumu { get; set; }
        public string Yakit { get; set; }

        [Required]
        public int Fiyat { get; set; }
       
    }
}
