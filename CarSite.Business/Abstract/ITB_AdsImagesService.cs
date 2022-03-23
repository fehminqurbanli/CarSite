using CarSite.Core.Utilities.Results;
using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.Abstract
{
    public interface ITB_AdsImagesService
    {
        IDataResult<List<TB_AdsImages>> GetAll();
        IDataResult<TB_AdsImages> GetById(int id);
        IResult Add(TB_AdsImages tB_AdsImages);
        IResult Update(TB_AdsImages tB_AdsImages);
        IResult Delete(TB_AdsImages tB_AdsImages);
    }
}
