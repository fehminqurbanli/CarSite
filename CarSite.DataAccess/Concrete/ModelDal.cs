using CarSite.Core.DataAccess.EntityFramework;
using CarSite.DataAccess.Abstract;
using CarSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.DataAccess.Concrete
{
    public class ModelDal:EfCoreRepositoryBase<Model,EfCoreDbContext>,IModelDal
    {
    }
}
