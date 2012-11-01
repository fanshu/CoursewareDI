using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.DataAccess;
using Courseware.Domain;
using Courseware.Service;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Unity.AutoRegistration;

namespace Courseware.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //PoorMansDI();

            UnityDI();

            UnityXmlConfigDI();

            //UnityAutoRegistration();

            //AmbientContextProgress();

            //ConstrainedConstruction();
        }

        private static void ConstrainedConstruction()
        {
            var connectionstring = "db=northwind";

            // Get concrete type from configuration file, for late-binding
            var repositoryType = Type.GetType("Courseware.DataAccess.SqlStudentProgressRepository, Courseware.DataAccess", true);

            // Reflection
            var repository = (SqlStudentProgressRepository)Activator.CreateInstance(repositoryType, connectionstring);

            IStudentProgressService svc = new StudentProgressConstrainedConstructorService(repository);

            Console.WriteLine(svc.GetStudentProgressV2(55));
            Console.ReadLine();
        }

        private static void AmbientContextProgress()
        {
            StudentContext.Current = new ChineseStudentContext();

            // Register
            var container = new UnityContainer();
            container.RegisterType<IStudentProgressService, StudentProgressService>();

            // Resolve
            var svc = container.Resolve<IStudentProgressService>();

            Console.WriteLine(svc.GetStudentProgressV2(55));
            Console.ReadLine();
        }

        private static void UnityAutoRegistration()
        {
            // Register
            var container = new UnityContainer();

            container
                .ConfigureAutoRegistration()
                .LoadAssemblyFrom(typeof(ICourseRepository).Assembly.Location)
                .LoadAssemblyFrom(typeof(ICourseAppService).Assembly.Location)
                .LoadAssemblyFrom(typeof(SqlCourseRepository).Assembly.Location)
                .Include(If.ImplementsITypeName, Then.Register())
                .ExcludeSystemAssemblies()
                .ApplyAutoRegistration();

            // Resolve
            var svc = container.Resolve<ICourseAppService>();
            var descriptions = svc.GetCourseDescriptions(new int[] { 10, 20, 30 });


            Console.WriteLine(descriptions);
            Console.ReadLine();
        }

        private static void UnityXmlConfigDI()
        {
            // Register
            var container = new UnityContainer();
            container.LoadConfiguration();

            // Resolve
            var svc = container.Resolve<ICourseAppService>();
            var descriptions = svc.GetCourseDescriptions(new int[] { 10, 20, 30 });


            Console.WriteLine(descriptions);
            Console.ReadLine();
        }

        private static void UnityDI()
        {
            CourseAppV2Service sv = new CourseAppV2Service(null);
            sv.Formatter = null;

            // Register
            var container = new UnityContainer();
            container.RegisterType<ICourseRepository, SqlCourseRepository>();
            container.RegisterType<ICourseAppService, CourseAppV2Service>();

            // Resolve
            var svc = container.Resolve<ICourseAppService>();
            var descriptions = svc.GetCourseDescriptions(new int[] { 10, 20, 30 });


            Console.WriteLine(descriptions);
            Console.ReadLine();
        }

        private static void PoorMansDI()
        {
            int[] input = new int[] {10, 20, 30};

            ICourseAppService svc = new CourseAppService(new SqlCourseRepository());
            var descriptions = svc.GetCourseDescriptions(input);

            Console.WriteLine(descriptions);
            Console.ReadLine();
        }


    }
}
