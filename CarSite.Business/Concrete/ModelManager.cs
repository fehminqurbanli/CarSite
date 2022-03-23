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
    public class ModelManager : IModelService
    {
        private readonly IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public IResult Add(Model model)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Model model)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Model>> GetAll()
        {
            var result = _modelDal.GetAll();
            return new SuccessDataResult<List<Model>>(result);
        }

        public IDataResult<Model> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
