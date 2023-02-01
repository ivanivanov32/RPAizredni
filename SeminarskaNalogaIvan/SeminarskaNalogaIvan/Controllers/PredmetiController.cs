using SeminarskaNalogaIvan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeminarskaNalogaIvan.Controllers
{
    public class PredmetiController : Controller
    {
        // GET: Predmeti
        public ActionResult Index()

        {
            var PredmetiList = new List<Predmeti>{
 new Predmeti() { PredmetiId = 1, PredmetiName = "Matematika", Oceni = 4 } ,
 new Predmeti() { PredmetiId = 2, PredmetiName = "Zgodovina",Oceni  = 1 } ,
 new Predmeti() { PredmetiId = 3, PredmetiName = "Slovenscina", Oceni = 3 } ,
 new Predmeti() { PredmetiId = 4, PredmetiName = "Biologija" , Oceni = 5 } ,
 new Predmeti() { PredmetiId = 5, PredmetiName = "Informatika" , Oceni = 3 } ,
 new Predmeti() { PredmetiId = 4, PredmetiName = "Kemija" ,Oceni = 1 } ,
 new Predmeti() { PredmetiId = 4, PredmetiName = "Fizika" , Oceni = 2 }
 };
            // Get the students from the database in the real application
            return View(PredmetiList);
            
        }
    }
}