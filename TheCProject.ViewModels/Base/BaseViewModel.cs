using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCProject.ViewModels.Base
{
    public class BaseViewModel
    {
        public string Identifier { get; set; }

        public string HashedId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public string CreateUser { get; set; }

        public string UpdateUser { get; set; }

    }
}
