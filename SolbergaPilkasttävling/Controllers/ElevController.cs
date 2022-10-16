using Microsoft.AspNetCore.Mvc;
using SolbergaPilkasttävling.Models;
using System.Reflection.Metadata.Ecma335;

namespace SolbergaPilkasttävling.Controllers
{
    public class ElevController : Controller
    {
        public IActionResult Elever()
        {
            List<ElevDetaljer> elever = new()
            {
                new ElevDetaljer {FörNamn = "Kalle", EfterNamn = "Andersson", Klass = "TE20A", Poäng = 8},
                new ElevDetaljer {FörNamn = "Sven", EfterNamn = "Hultman", Klass = "TE21", Poäng = 12},
                new ElevDetaljer {FörNamn = "Anna", EfterNamn = "Andersson", Klass = "TE21", Poäng = 22},
                new ElevDetaljer {FörNamn = "Berit", EfterNamn = "Andersson", Klass = "NA22", Poäng = 2},
            };

            Elev VM = new Elev();
            VM.ElevLista = elever;
            return View(VM);
        }
    }
}
