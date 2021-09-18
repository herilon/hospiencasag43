using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente{
        Paciente AddPaciente (Paciente paciente);
        IEnumerable<Paciente> GetAllPacientes();
        void DeletePaciente(int idPaciente);
        public Paciente GetPaciente(int idPaciente);
        public Paciente UpdatePaciente(Paciente paciente);
        Medico AsignarMedico(int idPaciente, int idMedico);

    }
}