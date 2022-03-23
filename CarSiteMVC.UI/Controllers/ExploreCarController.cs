using CarSite.Business.Abstract;
using CarSite.Entities.Concrete;
using CarSiteMVC.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSiteMVC.UI.Controllers
{
    public class ExploreCarController : Controller
    {
        
        private readonly ITB_AdsService _tB_AdsService;
        private readonly IModelService _modelService;
        private readonly IBrandService _brandService;
        private readonly ITB_AdsImagesService _tB_AdsImagesService;
        private readonly IGeneralInfoService _generalInfoService;

        public ExploreCarController(ITB_AdsService tB_AdsService, IModelService modelService, IBrandService brandService, ITB_AdsImagesService tB_AdsImagesService, IGeneralInfoService generalInfoService)
        {
            _tB_AdsService = tB_AdsService;
            _modelService = modelService;
            _brandService = brandService;
            _tB_AdsImagesService = tB_AdsImagesService;
            _generalInfoService = generalInfoService;
        }

        public IActionResult Index()
        {

            CarViewModel carViewModel = new CarViewModel
            {
                GeneralInfos = _generalInfoService.GetAll().Data,
                Models = _modelService.GetAll().Data,
                Brands=_brandService.GetAll().Data,
                TB_AdsImages=_tB_AdsImagesService.GetAll().Data,
                tB_Ads=new TB_Ads()
                {
                    TB_AdsImages=_tB_AdsImagesService.GetAll().Data
                },
                TB_Ads_List=_tB_AdsService.GetAll().Data.OrderByDescending(a=>a.Id).ToList()
            };
            //var result = _tB_AdsService.GetAll().Data;
            return View(carViewModel);
        }



        public IActionResult Details(int id)
        {
            CarViewModel carViewModel = new CarViewModel()
            {
                GeneralInfos=_generalInfoService.GetAll().Data,
                Models=_modelService.GetAll().Data,
                Brands=_brandService.GetAll().Data,
                TB_AdsImages=_tB_AdsImagesService.GetAll().Data.Where(x=>x.Ads_Id==id).ToList(),
                TB_Ads_List=_tB_AdsService.GetAll().Data.Where(x=>x.Id==id).ToList()
            };
            return View(carViewModel);
        }


        public IActionResult ResearchPage(int brandId/*,int modelId*/)
        {
            var models = _modelService.GetAll().Data.Where(x => x.BrandId == brandId);
            List<TB_Ads> ads=new List<TB_Ads>();

            foreach (var item in models)
            {
                ads.Add(_tB_AdsService.GetAll().Data.FirstOrDefault(x=>x.Model_Id==item.Id));
            }
            CarViewModel carViewModel = new CarViewModel
            {
                GeneralInfos = _generalInfoService.GetAll().Data,
                Models = _modelService.GetAll().Data,
                Brands = _brandService.GetAll().Data,
                TB_AdsImages = _tB_AdsImagesService.GetAll().Data,
                //tB_Ads = new TB_Ads()
                //{
                    
                //    TB_AdsImages = _tB_AdsImagesService.GetAll().Data
                //},
                TB_Ads_List = ads.ToList()
            };
            return View("Research",carViewModel);
            //_tB_AdsService.GetAll().Data.Where(/*x => x.Name.Contains(searching)*/x => x.Name == searching /*|| searching == ""*/)
        }

        public IActionResult Research()
        {
            CarViewModel carViewModel = new CarViewModel
            {
                GeneralInfos = _generalInfoService.GetAll().Data,
                Models = _modelService.GetAll().Data,
                Brands = _brandService.GetAll().Data,
                TB_AdsImages = _tB_AdsImagesService.GetAll().Data,
                tB_Ads = new TB_Ads()
                {
                    TB_AdsImages = _tB_AdsImagesService.GetAll().Data
                },
                TB_Ads_List = _tB_AdsService.GetAll().Data.OrderByDescending(a => a.Id).ToList()
            };
            return View(carViewModel);
        }
    }
}
