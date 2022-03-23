using Autofac;
using Autofac.Extras.DynamicProxy;
using CarSite.Business.Abstract;
using CarSite.Business.Concrete;
using CarSite.DataAccess.Abstract;
using CarSite.DataAccess.Concrete;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModules:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfCoreDbContext>().InstancePerDependency();
            builder.RegisterType<BrandDal>().As<IBrandDal>().InstancePerDependency();
            builder.RegisterType<ModelDal>().As<IModelDal>().InstancePerDependency();
            builder.RegisterType<GeneralTypeDal>().As<IGeneralTypeDal>().InstancePerDependency();
            builder.RegisterType<GeneralInfoDal>().As<IGeneralInfoDal>().InstancePerDependency();
            builder.RegisterType<TB_AdsDal>().As<ITB_AdsDal>().InstancePerDependency();
            builder.RegisterType<TB_AdsImagesDal>().As<ITB_AdsImagesDal>().InstancePerDependency();

            builder.RegisterType<BrandManager>().As<IBrandService>().InstancePerDependency();
            builder.RegisterType<ModelManager>().As<IModelService>().InstancePerDependency();
            builder.RegisterType<GeneralTypeManager>().As<IGeneralTypeService>().InstancePerDependency();
            builder.RegisterType<GeneralInfoManager>().As<IGeneralInfoService>().InstancePerDependency();
            builder.RegisterType<TB_AdsManager>().As<ITB_AdsService>().InstancePerDependency();
            builder.RegisterType<TB_AdsImagesManager>().As<ITB_AdsImagesService>().InstancePerDependency();



            //var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            //builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            //{
            //    Selector = new AspectInterceptorSelector()
            //}).SingleInstance();

        }
    }
}
