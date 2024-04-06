using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace L01P022021EM601.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name ="id")]
        public int id { get; set; }
        [Display(Name = "codigo")]
        public string? codigo { get; set; }
        [Display(Name = "nombre")]
        public string? nombre { get; set; }
        [Display(Name = "apellidos")]
        public string? apellidos {  get; set; }
        [Display(Name = "dui")]
        public int? dui {  get; set; }
        [Display(Name = "estado")]
        public int? estado { get; set; }
    }
}
