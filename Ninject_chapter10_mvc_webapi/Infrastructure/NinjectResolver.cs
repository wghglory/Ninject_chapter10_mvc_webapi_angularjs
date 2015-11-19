﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Web.Common;
using Ninject_chapter10_mvc_webapi.Models;

namespace Ninject_chapter10_mvc_webapi.Infrastructure
{
    public class NinjectResolver : System.Web.Http.Dependencies.IDependencyResolver,
            System.Web.Mvc.IDependencyResolver
    {
        private IKernel kernel;

        public NinjectResolver() : this(new StandardKernel()) { }

        public NinjectResolver(IKernel ninjectKernel)
        {
            kernel = ninjectKernel;
            AddBindings(kernel);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public void Dispose()
        {
            // do nothing
        }

        private void AddBindings(IKernel kernel)
        {
            kernel.Bind<IRepository>().To<Repository>().InRequestScope();
        }
    }
}