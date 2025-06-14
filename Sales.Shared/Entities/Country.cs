﻿using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(80, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Name { get; set; } = null!;

        public ICollection<State>? States { get; set; }
        public int StatesNumber => States?.Count ?? 0;
    }
}
