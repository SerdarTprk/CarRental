using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class Brand:EntityBase,IEntity
    {
        public Brand()
        {
            Model = new HashSet<Model>();
        }

        public string BrandName { get; set; }
        public virtual ICollection<Model> Model { get; set; }

    }
}
