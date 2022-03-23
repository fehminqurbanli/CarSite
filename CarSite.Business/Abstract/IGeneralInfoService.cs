using CarSite.Core.Utilities.Results;
using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.Abstract
{
    public interface IGeneralInfoService
    {
        IDataResult<List<GeneralInfo>> GetAll();
        IDataResult<GeneralInfo> GetById(int id);
        IResult Add(GeneralInfo generalInfo);
        IResult Update(GeneralInfo generalInfo);
        IResult Delete(GeneralInfo generalInfo);
    }
}
