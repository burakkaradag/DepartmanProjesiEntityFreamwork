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
    public class PersonelController : Controller
    {
        RepPersonel repper;
        PersonelModel model;
        RepBolum repbol;
        public PersonelController(RepPersonel _repper, PersonelModel _model, RepBolum _repbol)
        {
            repper = _repper;
            model = _model;
            repbol = _repbol;
        }
        public IActionResult Liste()
        {
            model.olist = repper.Doldur();
            return View(model);
        }

        public IActionResult Ekle()
        {
            model.Personel = new Personel();
            model.Bolumdrpdwn = repbol.ComboDoldur(model.Bolumdrpdwn);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Ekle(PersonelModel pm)
        {

            repper.Add(pm.Personel);
            await repper.Comit();
            return RedirectToAction("Liste");
        }

        public async Task<IActionResult> Detay(int id)
        {
            model.Personel = await repper.Find(id);
            return View(model);
        }

        public async Task<IActionResult> Guncel(int id)
        {
            model.Personel = await repper.Find(id);
            model.Bolumdrpdwn = repbol.ComboDoldur(model.Bolumdrpdwn);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Guncel(PersonelModel pm)
        {
            repper.Update(pm.Personel);
            await repper.Comit();
            return RedirectToAction("Liste");
        }

        public async Task<IActionResult> Sil(int id)
        {
            model.Personel = await repper.Find(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Sil(PersonelModel pm)
        {
            repper.Delete(pm.Personel);
            await repper.Comit();
            return RedirectToAction("Liste");
        }
    }
}