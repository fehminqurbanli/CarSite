using CarSite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Entities.Concrete
{
    public class TB_AdsImages:IEntity
    {
        //[Key]
        public int Id { get; set; }
        public string CarImagePath { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ads_Id { get; set; }
        public TB_Ads TB_Ads { get; set; }
        //[NotMapped]
        //public List<IFormFile> Photos { get; set; }
    }
}
