using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioEnfermera{
        IEnumerable<Enfermera> GetAllEnfermeras();
    }
}