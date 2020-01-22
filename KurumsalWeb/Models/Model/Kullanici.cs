using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KurumsalWeb.Models.Model
{[Table("Kullanici")]
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }

        [Required,StringLength(100,ErrorMessage = "100 Karakter Olmalidir")]
        public string Ad { get; set; }
        [Required, StringLength(100, ErrorMessage = "100 Karakter Olmalidir")]
        
        public string Soyad { get; set; }

                
        [Required, StringLength(50,ErrorMessage ="50 Karakter olmalidir" )]
        public string Eposta { get; set; }
        
        [Required, StringLength(50,ErrorMessage = "50 Karakter olmalidir")]
        public string Sifre { get; set; }
        
        //0 normal kullanici, 1 admin kullanici
        public Boolean? isAdmin { get; set; }

    }
}