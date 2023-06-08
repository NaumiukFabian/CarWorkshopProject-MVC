using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop
{
    public class CarWorkshopDto
    {
        [Required(ErrorMessage = "Proszę podać nazwę sklepu")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Nazwa sklepu musi mieć od 2 do 20 znaków")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Proszę podać opis sklepu")]
        public string? Description { get; set; }
        public string? About { get; set; }
        [StringLength(12, MinimumLength = 8)]
        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? EncodedName { get; set; }     
    }
}
