using CarSite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Entities.Concrete
{
    public class Model:IEntity
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }
        public Brand brand { get; set; }
    }
}
