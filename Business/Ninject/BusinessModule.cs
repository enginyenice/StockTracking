using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();

            Bind<ISupplierService>().To<SupplierManager>().InSingletonScope();
            Bind<ISupplierDal>().To<EfSupplierDal>().InSingletonScope();            
            
            Bind<IStoreService>().To<StoreManager>().InSingletonScope();
            Bind<IStoreDal>().To<EfStoreDal>().InSingletonScope();            
            
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
        }
    }
}
