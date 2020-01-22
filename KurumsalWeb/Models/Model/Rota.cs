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

        //latitude,longitude degerlerini tutacak
        [Required]
        public String startPoint { get; set; }

        //latitude,longitude degerlerini tutacak
        [Required]
        public String endPoint { get; set; }

        public int? userId { get; set; }

    }
}