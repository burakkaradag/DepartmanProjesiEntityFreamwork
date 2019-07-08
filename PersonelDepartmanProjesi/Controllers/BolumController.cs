using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonelDepartmanProjesi.Models;
using static PersonelDepartmanProjesi.BL.Repository;
using static PersonelDepartmanProjesi.ENT.PersonelEntities;

namespace PersonelDepartmanProjesi.Controllers
{
    public class BolumController : Controller
    {
        RepBolum repbol;
        BolumModel model;
        public BolumController(RepBolum _repbol, BolumModel _model)
        {
            repbol = _repbol;
            model = _model;

        }
        public IActionResult Liste()
        {
            model.blist = repbol.Doldur();
            return View(model);
        }

        public async Task<IActionResult> Detay(int id)
        {
            model.bolum = await repbol.Find(id);
            return View(model);
        }

        public async Task<IActionResult> Guncel(int id)
        {
            model.bolum = await repbol.Find(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Guncel(BolumModel bm)
        {
            repbol.Update(bm.bolum);
            await repbol.Comit();
            return RedirectToAction("Liste");
        }

        public async Task<IActionResult> Sil(int id)
        {
            model.bolum = await repbol.Find(id);

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Sil(BolumModel bm)
        {
            repbol.Delete(bm.bolum);
            await repbol.Comit();

            return RedirectToAction("Liste");
        }

        public IActionResult Ekle()
        {
            model.bolum = new Bolum();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Ekle(BolumModel bm)
        {
          
            repbol.Add(bm.bolum);
            await repbol.Comit();

            return RedirectToAction("Liste");
        }
    }
}