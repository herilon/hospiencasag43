using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Fontend.Pages.Medicos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public Medico medico {get; set;}
        public CreateModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        }
        public void OnGet()
        {
            medico = new Medico();
        }

        public IActionResult OnPost(Medico medico)
        {
            if (ModelState.IsValid)
            {
                _repoMedico.AddMedico(medico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}
