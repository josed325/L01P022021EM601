using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace L01P022021EM601.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "id")]
        public int id { get; set; }
        [Display(Name = "facultad")]
        public string? facultad {  get; set; }
    }
}
