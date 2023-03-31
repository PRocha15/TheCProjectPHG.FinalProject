using CakeDatabase.DbEntities.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDatabase.DbEntities
{
    public class CakeFile : BaseEntity2 // resource
    {
        public byte[] FileBytes { get; set; }

        public string Description { get; set; }

        public int FileExtension { get; set; }

        public string? FileChecksum { get; set; }

        public string CakeName { get; set; }

        public string CakeFlavour { get; set; }

        [ForeignKey("Cake")]

        public int CakeID { get; set; }

        public virtual Cake Cake { get; set; }

    }
}
