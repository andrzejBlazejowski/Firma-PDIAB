using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Firma.Intranet.Models.CMS
{
    public class Aktualnosc
    {
        [Key]
        public int IdAktualnosci { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [MaxLength(10, ErrorMessage = "Tytuł może zawierać maksymalnie 10 znaków ")]
        [Display(Name = "Tytuł odnośnika do aktualnosci")]
        public string LinkTytul { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [MaxLength(30, ErrorMessage = "Tytuł może zawierać maksymalnie 30 znaków ")]
        [Display(Name = "Tytuł aktualnosci")]
        public string Tytuł { get; set; }

        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Tresc { get; set; }

        [Required(ErrorMessage = "pozycja jest wymagana")]
        [Display(Name = "pozycja wyświetlania")]
        public int Pozycja { get; set; }
    }
}
