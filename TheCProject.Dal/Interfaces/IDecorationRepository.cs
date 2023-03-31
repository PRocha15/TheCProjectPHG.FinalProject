using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;

namespace TheCProject.Dal.Interfaces
{
    public interface IDecorationRepository
    {
        IQueryable<Decoration> Decorations { get; }

        Decoration Insert(Decoration decoration);

        Decoration Update(Decoration decoration);
        bool Delete(Guid identifier);
    }
}
