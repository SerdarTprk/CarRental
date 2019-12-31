
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DTO
{
    public class BrandDTO
    {
        public BrandDTO()
        {
            Models = new HashSet<ModelDTO>();
        }
        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public virtual ICollection<ModelDTO> Models { get; set; }

    }
}
