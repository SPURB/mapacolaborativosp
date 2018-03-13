using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using smul.mapa.final.core.Data;

namespace smul.mapa.final.core.ControllersApi
{
    [Produces("application/json")]
    [Route("api/Registrations")]
   
    public class RegistrationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistrationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public object Get()
        {
            var registrations = _context.Registration.ToList();

            return registrations.Select(x => new
            {
                x.ID,
                x.Lat,
                x.Lng,
                x.NomeInstituicao,
                address = new
                {
                    x.CEP,
                    x.Rua,
                    x.Numero
                },
                x.TelefoneFixo,
                x.TelefoneCelular,
                x.Segmento,
                x.Site,
                x.ProfileFacebook,
                x.Email


            });
        }
    }
}