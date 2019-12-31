
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class Model : EntityBase, IEntity

    {
        public Model()
        {
            Cars = new HashSet<Car>();
        }
        public string ModelName { get; set; }
        public DateTime? ModelYear { get; set; }
        public Guid BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

    }
}
