using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        //crea referencia
        [Required]
        public byte GenreId { get; set; }
        //objeto referenciado
        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }
        //anade rango de validacion 
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}