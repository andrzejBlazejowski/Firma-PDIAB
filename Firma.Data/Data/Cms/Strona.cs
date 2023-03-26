using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firma.Data.Data.Cms
{
    public class Strona
    {
        [Key]
        public int IdStrony { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [MaxLength(10, ErrorMessage = "Tytuł może zawierać maksymalnie 10 znaków ")]
        [Display(Name = "Tytuł odnośnika do strony")]
        public string LinkTytul { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [MaxLength(30, ErrorMessage = "Tytuł może zawierać maksymalnie 30 znaków ")]
        [Display(Name = "Tytuł strony")]
        public string Tytuł { get; set; }

        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Tresc { get; set; }

        [Required(ErrorMessage = "pozycja jest wymagana")]
        [Display(Name = "pozycja wyświetlania")]
        public int Pozycja { get; set; }
    }
}
