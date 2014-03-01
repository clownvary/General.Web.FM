using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autofac;
using Autofac.Builder;
using Autofac.Configuration;
using Autofac.Integration.Mvc;
using General.Service.Contract;
using General.Service;
using General.Model;
using System.Configuration;
using System.IO;
namespace General.Ioc
{
    public class Aurofac
    {
        public static ContainerBuilder RegisterService()
        {
            string path = System.Configuration.ConfigurationManager.AppSettings["path"];
            var builder = new ContainerBuilder();
            var assembles = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("General")).ToList();
            assembles.Add(Assembly.LoadFrom(path+@"\General.Service.dll"));
            builder.RegisterControllers(assembles.ToArray());
          // builder.RegisterType<TeacherService>().As<ITeacherService>();
            builder.RegisterAssemblyTypes(assembles.ToArray()).Where(a => a.Name.EndsWith("Repo")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(assembles.ToArray()).Where(a => a.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
            return builder;
           
        }
       
    }
}
