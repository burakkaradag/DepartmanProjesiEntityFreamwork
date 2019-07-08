using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PersonelDepartmanProjesi.ENT
{
   public class PersonelEntities
    {
        [Table("Personel")]
        public class Personel
        {
            [Key]
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int BolumId { get; set; }

            [ForeignKey("BolumId")]
            public Bolum Bolum { get; set; }
        }
        [Table("Bolum")]
        public class Bolum
        {
            [Key]
            public int Id { get; set; }
            public string Ad { get; set; }

            public ICollection<Personel> Personel { get; set; }

        }
    }
}
