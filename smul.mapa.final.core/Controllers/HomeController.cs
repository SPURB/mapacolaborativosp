using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using smul.mapa.final.core.Data;
using smul.mapa.final.core.Models;

namespace smul.mapa.final.core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,NomeInstituicao,TelefoneFixo,TelefoneCelular,Email,Site,ProfileFacebook,NomeRepresentante,Rua,Numero,CEP,PrefeituraRegional,Segmento,Tematica,TempoDeAtucao,Registro,Lat,Lng")] Registration registration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index", registration);
        }
        /* public IActionResult About()
         {
             ViewData["Message"] = "Your application description page.";

             return View();
         }

         public IActionResult Contact()
         {
             ViewData["Message"] = "Your contact page.";

             return View();
         }*/

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
