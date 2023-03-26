using System.ComponentModel.DataAnnotations;

namespace Firma.Data.Data.Sklep
{
    public class Rodzaj
    {

        [Key]
        public int IdRodzaju { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MaxLength(30, ErrorMessage = "Nazwa może zawierać maksymalnie 30 znaków")]
        [Display(Name = "Nazwa odnośnika do aktualnosci")]
        public string Nazwa { get; set; }

        public string Opis { get; set; }

        public List<Towar> Towar { get; set; }
    }
}
