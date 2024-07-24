
using System;
using System.ComponentModel.DataAnnotations;


namespace Ejercicio5.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public bool Completada { get; set; }
    }
}
