using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSiteMVC.UI.ViewModels
{
    public class CarViewModel
    {
        public TB_Ads tB_Ads { get; set; }
        public List<TB_Ads> TB_Ads_List { get; set; }
        public List<TB_AdsImages> TB_AdsImages { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Model> Models { get; set; }
        public List<GeneralInfo> GeneralInfos { get; set; }



        public List<GeneralInfo> Transmission { get; set; }
        public List<GeneralInfo> BanType { get; set; }
        public List<GeneralInfo> SpeedBox { get; set; }
        public List<GeneralInfo> Color { get; set; }
    }
}
