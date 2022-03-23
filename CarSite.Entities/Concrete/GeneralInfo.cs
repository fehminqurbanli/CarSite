using CarSite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Entities.Concrete
{
    public class GeneralInfo:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public GeneralType GeneralType { get; set; }
    }
}
