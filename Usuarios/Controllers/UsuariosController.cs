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
        public IActionResult Index(int data)
        {
            var url = Url.Action("Metodo", "Usuarios");
            //return View("Index",data);
            return Redirect(url);
        }

        public IActionResult Metodo()
        {
            return View();
        }
    }
}
