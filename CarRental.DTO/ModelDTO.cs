using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DTO
{
    public class ModelDTO
    {
        public Guid Id { get; set; }
        public string ModelName { get; set; }
        public DateTime? ModelYear { get; set; }
        public Guid BrandId { get; set; }

        public virtual ICollection<CarDTO> Cars { get; set; }

    }
}
