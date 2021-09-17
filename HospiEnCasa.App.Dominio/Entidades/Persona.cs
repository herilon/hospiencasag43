namespace HospiEnCasa.App.Dominio
{
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefono { get; set; }
        // Genero de la persona
        public Genero Genero { set; get; }

    }
}