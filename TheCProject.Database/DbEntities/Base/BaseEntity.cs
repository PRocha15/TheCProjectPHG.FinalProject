using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCProject.Database.DbEntities.Base
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Guid Identifier { get; set; }


        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }


        public string UpdateUser { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
