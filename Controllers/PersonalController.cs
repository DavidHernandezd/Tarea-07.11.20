using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApplication.Models;

namespace firstApplication.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name = "David";
            personal.lastname = "Hernández";
            personal.age = 17;
            personal.direccion = "dh785246@gmail.com";
            personal.codigoEst = "SMIS051821";
            personal.telefono = 60449009 ;
            return View(personal);
        }
    }
}