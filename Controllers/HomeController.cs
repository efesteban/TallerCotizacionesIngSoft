using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cotizaciones.Models;
using Cotizaciones.Data;

namespace Cotizaciones.Controllers
{
    public class HomeController : Controller
    {
        private readonly CotizacionesContext _context;

        public HomeController(CotizacionesContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Login(string email, string pass)
        {
            //Validar Inicio de sesion

            if (email == null)
            {
                ViewData["Message"] = "No hay correo";
                return NotFound();
            }

            var usuario = _context.Usuarios.Where(m => m.Email == email);

            if(usuario == null){
                return NotFound();
            }else
            {

            int cant = usuario.Count();
            if (usuario.Count() == 0)
            {
                usuario = _context.Usuarios.Where(m => m.Rut == email);
                
                if(usuario.Count() == 0){
                    return NotFound();
                }else
                {
                    if(usuario.First().Contraseña.Equals(pass))
                    {   
                    
                        if(usuario.First().Perfil == 1){
                            ViewData["persona"] = usuario.First();
                            return View("~/Views/Home/InicioAdmin.cshtml"); 
                        }else
                        {
                            ViewData["persona"] = usuario.First();
                            return View("~/Views/Home/InicioUsuario.cshtml"); 
                        } 
                    }else{
                        return NotFound();
                    }
                }

            }else
            {
                if(usuario.First().Contraseña.Equals(pass))
                {   
                    

                    if(usuario.First().Perfil == 1){
                        ViewData["persona"] = usuario.First();
                        return View("~/Views/Home/InicioAdmin.cshtml"); 
                    }else
                    {
                        ViewData["persona"] = usuario.First();
                        return View("~/Views/Home/InicioUsuario.cshtml"); 
                    }
                }else{
                    return NotFound();
                }
            }

            }

               
        }
    }
}
