using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._12
{
    public partial class sotrudnik
    {
        public string Id
        {
            get
            {
                return $"{id}. ";
            }
        }
        public string IdMagazin
        {
            get
            {
                var mag = App.DB.magazine.Where(p => p.id == id_magazine).FirstOrDefault();
                return mag.name;
            }
        }
    }
}
