using Microsoft.AspNetCore.Mvc.Rendering;
using PersonelDepartmanProjesi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PersonelDepartmanProjesi.ENT.PersonelEntities;

namespace PersonelDepartmanProjesi.Models
{
    public class PersonelModel
    {
        public List<PersonelDTO> olist { get; set; }
        public Personel Personel { get; set; }
        public List<SelectListItem> Bolumdrpdwn { get; set; }
    }
}
