using CarSite.Core.Utilities.Results;
using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.Abstract
{
    public interface ITB_AdsService
    {
        IDataResult<List<TB_Ads>> GetAll();
        IDataResult<TB_Ads> GetById(int id);
        IResult Add(TB_Ads tB_Ads);
        IResult Update(TB_Ads tB_Ads);
        IResult Delete(TB_Ads tB_Ads);
    }
}
