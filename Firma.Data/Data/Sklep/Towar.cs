using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firma.Data.Data.Sklep
{
    public class Towar
    {

        [Key]
        public int IdTowaru { get; set; }

        [Required(ErrorMessage = "Kod jest wymagany")]
        [MaxLength(10, ErrorMessage = "Tytuł może zawierać maksymalnie 10 znaków ")]
        public string Kod { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Cena jest wymagany")]
        [Column(TypeName = "money")]
        public decimal Cena { get; set; }

        [Required(ErrorMessage = "link do zdjęcia jest wymagany")]
        [Display(Name = "Wybierz zdjęcie")]
        public string FotoUrl { get; set; }

        public string Opis { get; set; }

        public int RodzajId { get; set; }

        public Rodzaj Rodzaj { get; set; }
    }
}
