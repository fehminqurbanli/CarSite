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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(result);
        }

        public IDataResult<Brand> GetById(int id)
        {
            var result = _brandDal.Get(b => b.Id == id);
            return new SuccessDataResult<Brand>(result);
        }


        public IResult Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        

        public IResult Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
