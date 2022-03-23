using CarSite.Business.Abstract;
using CarSite.Core.Utilities.Results;
using CarSite.DataAccess.Abstract;
using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.Concrete
{
    public class TB_AdsManager : ITB_AdsService
    {
        private readonly ITB_AdsDal _tB_AdsDal;

        public TB_AdsManager(ITB_AdsDal tB_AdsDal)
        {
            _tB_AdsDal = tB_AdsDal;
        }

        public IResult Add(TB_Ads tB_Ads)
        {
            _tB_AdsDal.Add(tB_Ads);
            return new SuccessResult("Ads added");
        }

        public IResult Delete(TB_Ads tB_Ads)
        {
            _tB_AdsDal.Delete(tB_Ads);
            return new SuccessResult("Ads deleted");
        }



        public IDataResult<List<TB_Ads>> GetAll()
        {
            var result = _tB_AdsDal.GetAll();
            return new SuccessDataResult<List<TB_Ads>>(result, "Car listed");
        }

        public IDataResult<TB_Ads> GetById(int id)
        {
            var ads = _tB_AdsDal.Get(a => a.Id == id);
            return new SuccessDataResult<TB_Ads>(ads);
        }

        public IResult Update(TB_Ads tB_Ads)
        {
            _tB_AdsDal.Update(tB_Ads);
            return new SuccessResult();
        }
    }
}
