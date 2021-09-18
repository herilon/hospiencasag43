using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  
            //AddPaciente();
            IndexPacientes();

        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Juanita",
                Apellidos = "Gomez",
                NumeroTelefono = "3001645",
                Genero = Genero.Femenino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void IndexPacientes()
        {
            foreach (var paciente in _repoPaciente.GetAllPacientes())
            {
                Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
            }
        }
    }
}
