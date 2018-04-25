using Ninject;
using SportStoreMvc.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStoreMvc.WebUI
{
    public class NinjectWebCommon
    {
        public static void RegisterServices(IKernel kernel)
        {
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}