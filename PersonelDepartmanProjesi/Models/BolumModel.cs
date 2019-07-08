using PersonelDepartmanProjesi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PersonelDepartmanProjesi.ENT.PersonelEntities;

namespace PersonelDepartmanProjesi.Models
{
    public class BolumModel
    {
        public List<BolumDTO> blist { get; set; }
        public Bolum bolum { get; set; }
    }
}
