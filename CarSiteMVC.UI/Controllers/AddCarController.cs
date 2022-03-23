using CarSite.Business.Abstract;
using CarSite.Business.ValidationRules.FluentValidation;
using CarSite.Entities.Concrete;
using CarSiteMVC.UI.Filters;
using CarSiteMVC.UI.Models;
using CarSiteMVC.UI.ViewModels;
using FluentValidation.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CarSiteMVC.UI.Controllers
{
    [UserFilter]
    public class AddCarController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IGeneralInfoService _generalInfoService;
        private readonly ITB_AdsService _tB_AdsService;
        private readonly ITB_AdsImagesService _tB_AdsImagesService;
        private readonly IModelService _modelService;
        private readonly IWebHostEnvironment _webHost;

        public AddCarController(IBrandService brandService, IGeneralInfoService generalInfoService, ITB_AdsService tB_AdsService, IModelService modelService, IWebHostEnvironment webHost, ITB_AdsImagesService tB_AdsImagesService)
        {
            _brandService = brandService;
            _generalInfoService = generalInfoService;
            _tB_AdsService = tB_AdsService;
            _modelService = modelService;
            _webHost = webHost;
            _tB_AdsImagesService = tB_AdsImagesService;
        }
        
        public IActionResult Index()
        {
            CarViewModel carViewModel = new CarViewModel
            {
                Brands = _brandService.GetAll().Data,
                Transmission=_generalInfoService.GetAll().Data.Where(x=>x.TypeId==4).ToList(),
                BanType=_generalInfoService.GetAll().Data.Where(x=>x.TypeId==1).ToList(),
                SpeedBox=_generalInfoService.GetAll().Data.Where(x=>x.TypeId==5).ToList(),
                Color=_generalInfoService.GetAll().Data.Where(x=>x.TypeId==2).ToList(),
                tB_Ads=new TB_Ads()
            };
            return View(carViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Save(CarViewModel carViewModel, IFormFile[] ifile, TB_AdsImages images)
        {
            //Tb_Ads_Validator validationRules = new Tb_Ads_Validator();
            //ValidationResult result = validationRules.Validate(carViewModel.tB_Ads);
            //if (result.IsValid == false)
            //{

            //    return RedirectToAction("Index","AddCar");

            //}
            _tB_AdsService.Add(carViewModel.tB_Ads);

          
            foreach (var file in ifile)
            {
                string imgext = Path.GetExtension(file.FileName);

                if (imgext == ".jpg" || imgext == ".gif" || imgext == ".png")
                {
                    var saveimg = Path.Combine(_webHost.WebRootPath, "ImagesForAds", file.FileName);
                    var stream = new FileStream(saveimg, FileMode.Create);
                    await file.CopyToAsync(stream);
                    images.CarImagePath = file.FileName;
                    images.Ads_Id = carViewModel.tB_Ads.Id;
                    images.Id = 0;
                    _tB_AdsImagesService.Add(images);
                   
                }

            }


            return RedirectToAction("IndexDemo", "Home");
        }


        public JsonResult GetModelsForBrand(int id)
        {

            return Json(_modelService.GetAll().Data.Where(x=>x.BrandId==id).ToList());
        }










    }
}
