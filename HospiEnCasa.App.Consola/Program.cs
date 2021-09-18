using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico = new RepositorioMedico();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //IndexPacientes();
            //DeletePaciente();
            //IndexPacientes();
            //AddMedico();
            AsignarMedico();

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
        private static void DeletePaciente()
        {
            _repoPaciente.DeletePaciente(2);
        }

        private static void AddMedico()
        {
            var medico = new Medico
            {
                Nombre = "Juanita",
                Apellidos = "Gomez",
                NumeroTelefono = "3001645",
                Genero = Genero.Femenino,
                Especialidad = "Internista",
                Codigo = "123456",
                RegistroRethus = "ABC123",
            };
            _repoMedico.AddMedico(medico);
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 3);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }

    }
}
