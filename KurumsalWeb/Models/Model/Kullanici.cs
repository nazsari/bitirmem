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
        public int? AdminId { get; set; }
        public Admin Admin { get; set; }
        public ICollection<Rota> Rotas { get; set; }
    }
}