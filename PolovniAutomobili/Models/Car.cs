using System.ComponentModel.DataAnnotations;

namespace PolovniAutomobili.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [Range(1900,2300)]
        public int Godiste { get; set; }
        [Required]
        public double ZapreminaMotora { get; set; }
        [Required]
        public int Snaga { get; set; }
        [Required]
        public string Gorivo { get; set; }
        [Required]
        public string Karoserija { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Cena { get; set; }
        [Required]
        public string Kontakt { get; set; }
    }
}
