using CarSite.Core.Utilities.Results;
using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.Abstract
{
    public interface IGeneralTypeService
    {
        IDataResult<List<GeneralType>> GetAll();
        IDataResult<GeneralType> GetById(int id);
        IResult Add(GeneralType generalType);
        IResult Update(GeneralType generalType);
        IResult Delete(GeneralType generalType);
    }
}
