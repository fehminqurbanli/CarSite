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
    public class TB_AdsImagesManager : ITB_AdsImagesService
    {
        private readonly ITB_AdsImagesDal _tB_AdsImagesDal;

        public TB_AdsImagesManager(ITB_AdsImagesDal tB_AdsImagesDal)
        {
            _tB_AdsImagesDal = tB_AdsImagesDal;
        }

        public IResult Add(TB_AdsImages tB_AdsImages)
        {
            _tB_AdsImagesDal.Add(tB_AdsImages);
            return new SuccessResult();
        }

        public IResult Delete(TB_AdsImages tB_AdsImages)
        {
            _tB_AdsImagesDal.Delete(tB_AdsImages);
            return new SuccessResult();
        }

        public IDataResult<List<TB_AdsImages>> GetAll()
        {
            var result = _tB_AdsImagesDal.GetAll();
            return new SuccessDataResult<List<TB_AdsImages>>(result);
        }

        public IDataResult<TB_AdsImages> GetById(int id)
        {
            var ads = _tB_AdsImagesDal.Get(a => a.Id == id);
            return new SuccessDataResult<TB_AdsImages>(ads);
        }

        public IResult Update(TB_AdsImages tB_AdsImages)
        {
            _tB_AdsImagesDal.Update(tB_AdsImages);
            return new SuccessResult();
        }
    }
}
