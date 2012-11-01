using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.Domain;

namespace Courseware.Service
{
    public class CourseAppServiceLocatorService : ICourseAppService
    {
        // Dependency as field
        private readonly ICourseRepository _rep;

        public CourseAppServiceLocatorService()
        {
            // Resolve dependency by service locator
            //_rep = CourseAppLocator.GetService<ICourseRepository>();
        }

        public string GetCourseDescriptions(IEnumerable<int> courseIds)
        {
            return "foobar";
        }


    }
}
