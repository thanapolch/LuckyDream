using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Service.IService;
using Service.Service;
using System.Web.Mvc;
using Unity.AspNet.Mvc;

namespace LuckyDream.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterInstance<ILogingService>(new LogingService());
            container.RegisterType<IUtilityService, UtilityService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}