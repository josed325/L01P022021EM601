using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace L01P022021EM601.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "id")]
        public int id { get; set; }
        [Display(Name = "materia")]
        public string? materia { get; set; }
        [Display(Name = "unidades_valorativas")]
        public string? unidades_valorativas { get; set; }
        [Display(Name = "estado")]
        public string? estado { get; set; }

    }
}
