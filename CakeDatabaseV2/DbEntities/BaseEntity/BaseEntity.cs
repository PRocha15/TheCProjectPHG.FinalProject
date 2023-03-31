using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CakeDatabase.DbEntities.BaseEntity
{
    public class BaseEntity2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool Statuts { get; set; }

        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
