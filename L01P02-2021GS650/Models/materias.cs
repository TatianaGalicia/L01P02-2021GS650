using System.ComponentModel.DataAnnotations;
namespace L01P02_2021GS650.Models
{
    public class materias
    {
        [Key]

        [Display(Name = "ID")]
        public int id { get; set; }

        [Display(Name = "Materias")]

        public string? materia { get; set; }

        [Display(Name = "Unidades Valorativas")]

        public string? unidades_valorativas { get; set; }

        [Display(Name = "Estado")]

        public string? estado { get; set; }
    }
}
