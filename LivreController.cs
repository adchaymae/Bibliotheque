using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GLivreLM.Data;
using GLivreLM.Models;
using Microsoft.AspNetCore.Mvc;

namespace GLivreLM.Controllers
{
    public class LivreController : Controller
    {
        private static List<Livre> livres=LivreRepo.GetLivres();
        private static int Id = 2;
        public IActionResult Index()
        {
            ViewBag.livres = livres;
            //ViewData["livres"] = livres;
            return View();
        }
        // pour returner la page Ajouter
        [HttpGet]
        public IActionResult Ajouter()
        {
            Livre livre = new Livre();
            livre.Isbn = Id++;
            return View(livre);
        }
        // Ajouter le livre dans la liste
        [HttpPost]
        public IActionResult Ajouter(Livre livre)
        {
            livres.Add(livre);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Modifier(int id)
        {
            Livre livre = livres.Find(lv => lv.Isbn == id);

            return View(livre);
        }

        // Ajouter le livre dans la liste
        [HttpPost]
        public IActionResult Modifier(Livre livre)
        {
            Livre l = livres.Find(lv => lv.Isbn == livre.Isbn);
            l.Auteur = livre.Auteur;
            // + les autres attributs
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Supprimer(int id)
        {
            Livre livre = livres.Find(lv => lv.Isbn == id);
            livres.Remove(livre);
            return RedirectToAction("Index");
        }
    }
}