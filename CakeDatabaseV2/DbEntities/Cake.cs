using CakeDatabase.DbEntities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDatabase.DbEntities
{
    public class Cake : BaseEntity2
    {
        public string CakeName { get; set; }

        public string CakeDescription { get; set; }

        public DateTime Cakeconfeccion { get; set; }

        public string CakeType { get; set; }

        public ICollection<CakeFile> CakeFile { get; set; }
    }
}
