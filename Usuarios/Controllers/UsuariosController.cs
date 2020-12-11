using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Usuarios.Controllers
{
    //[Route("[controller]")]
    public class UsuariosController : Controller
    {
        //[Route("[controller]/[action]/{data:int}")]
        public IActionResult Index(double data)
        {
            //var url = Url.Action("Metodo", "Usuarios", new { edad=23, name="Leo"});
            //return View("Index",data);
            var url = Url.RouteUrl("Leo");
            return Redirect(url);
        }

        [HttpGet("[Controller]/[action]", Name = "Leo")]
        public IActionResult Metodo(int edad, String name)
        {
            var data = $"Nombre {name} Edad {edad}";
            return View("Index", data);
        }
    }
}
