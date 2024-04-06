using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace L01P022021EM601.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "id")]
        public int id { get; set; }
        [Display(Name = "departamento")]
        public string? departamento { get; set; }
    }
}
