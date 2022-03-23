using CarSite.Business.Abstract;
using CarSite.Core.Utilities.Results;
using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.Concrete
{
    public class GeneralTypeManager : IGeneralTypeService
    {
        public IResult Add(GeneralType generalType)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(GeneralType generalType)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<GeneralType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<GeneralType> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(GeneralType generalType)
        {
            throw new NotImplementedException();
        }
    }
}
