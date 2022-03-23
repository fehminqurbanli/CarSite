using CarSite.Core.Utilities.Results;
using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.Abstract
{
    public interface IModelService
    {
        IDataResult<List<Model>> GetAll();
        IDataResult<Model> GetById(int id);
        IResult Add(Model model);
        IResult Update(Model model);
        IResult Delete(Model model);
    }
}
