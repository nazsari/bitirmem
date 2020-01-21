using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KurumsalWeb.Models.Model
{
    [Table("Rota")]
    public class Rota
    {
        [Key]
        public int RotaId { get; set; }
        [Required]
        public DbGeography BaslangicGeography { get; set; }
        [Required]
        public DbGeography BitisGeography { get; set; }

        public int? KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

    }
}