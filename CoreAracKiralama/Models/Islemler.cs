using System;
using System.ComponentModel.DataAnnotations;

namespace CoreAracKiralama.Models
{
    public class Islemler
    {
            [Key] 
            public int IslemNo { get; set; }

            [Required]
            [StringLength(50)]
            public string AracSecimi { get; set; }
            public string AlisYeri { get; set; }
            public string IadeYeri { get; set; }

            [Required]
            public DateTime AlisTarihi { get; set; }
            public DateTime IadeTarihi { get; set; }

            [Required]
            [StringLength(25)]
            public string AlisSaati { get; set; }
            public string IadeSaati { get; set; }
    }
}
