using Microsoft.AspNetCore.Mvc.Rendering;
using PersonelDepartmanProjesi.DAL;
using PersonelDepartmanProjesi.DTO;
using PersonelDepartmanProjesi.REP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonelDepartmanProjesi.ENT.PersonelEntities;

namespace PersonelDepartmanProjesi.BL
{
    public class Repository
    {
        public class RepBolum : BaseRepository<Bolum>
        {
            public RepBolum(PersonelContext db) : base(db)
            {

            }

            public List<BolumDTO> Doldur()
            {
                return Qlist().Select(x => new BolumDTO
                {
                    Id = x.Id,
                    Ad = x.Ad

                }).ToList();
            }

            public List<SelectListItem> ComboDoldur(List<SelectListItem> item)
            {
                return item = Qlist().Select(x => new SelectListItem() { Text = x.Ad, Value = x.Id.ToString() }).ToList();

            }

        }
        public class RepPersonel : BaseRepository<Personel>
        {
            private PersonelContext _db;
            public RepPersonel(PersonelContext db) : base(db)
            {
                _db = db;
            }
            public async override Task<Personel> Find(int id)
            {
                var aranan = Set().Find(id);
                await _db.Entry(aranan).Reference(p => p.Bolum).LoadAsync();
                return aranan;
            }
            public List<PersonelDTO> Doldur()
            {
                return Qlist().Select(x => new PersonelDTO
                {
                    Id = x.Id,
                    Ad = x.Ad,
                    Soyad = x.Soyad,
                    Bolumad = x.Bolum.Ad

                }).ToList();
            }
        }
    }
}
