using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefono { get; set; }
        // Genero de la persona
        public Genero Genero { set; get; }

    }
}