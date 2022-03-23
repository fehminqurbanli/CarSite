using CarSite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Entities.Concrete
{
    public class Brand:IEntity
    {
        public Brand()
        {
            Models = new List<Model>();
        }

        public int Id { get; set; }
        public string BrandName { get; set; }
        public List<Model> Models { get; set; }
    }
}
