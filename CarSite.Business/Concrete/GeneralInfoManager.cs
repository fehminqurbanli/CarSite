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
    public class GeneralInfoManager : IGeneralInfoService
    {
        private readonly IGeneralInfoDal _generalInfoDal;

        public GeneralInfoManager(IGeneralInfoDal generalInfoDal)
        {
            _generalInfoDal = generalInfoDal;
        }

        public IResult Add(GeneralInfo generalInfo)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(GeneralInfo generalInfo)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<GeneralInfo>> GetAll()
        {
            var result = _generalInfoDal.GetAll();
            return new SuccessDataResult<List<GeneralInfo>>(result);
        }

        public IDataResult<GeneralInfo> GetById(int id)
        {
            var result = _generalInfoDal.Get(g => g.Id == id);
            return new SuccessDataResult<GeneralInfo>(result);
        }

        public IResult Update(GeneralInfo generalInfo)
        {
            throw new NotImplementedException();
        }
    }
}
