﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(80, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        public ICollection<City>? Cities { get; set; }
        public int CitiesNumber => Cities?.Count ?? 0;
    }
}
