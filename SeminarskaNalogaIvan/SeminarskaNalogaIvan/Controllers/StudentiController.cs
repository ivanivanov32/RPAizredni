using SeminarskaNalogaIvan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeminarskaNalogaIvan.Controllers
{
    public class StudentiController : Controller
    {
        // GET: Studenti
        public ActionResult Index()
        {
          
            var studentiList = new List<Studenti>{
 new Studenti() { StudentiId = 1, StudentiName = "Miha", Age = 18 } ,
 new Studenti() { StudentiId = 2, StudentiName = "Anže", Age = 21 } ,
 new Studenti() { StudentiId = 3, StudentiName = "Martina", Age = 25 } ,
 new Studenti() { StudentiId = 4, StudentiName = "Andrej" , Age = 20 } ,
 new Studenti() { StudentiId = 5, StudentiName = "Lukas" , Age = 31 } ,
 new Studenti() { StudentiId = 4, StudentiName = "Filip" , Age = 17 } ,
 new Studenti() { StudentiId = 4, StudentiName = "Tijana" , Age = 19 }
 };

            // get student from the database
           
            return View();
            
            }
    }
}