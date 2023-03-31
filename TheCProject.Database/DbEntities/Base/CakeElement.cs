using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCProject.Database.DbEntities.Base
{
    public class CakeElement:BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
