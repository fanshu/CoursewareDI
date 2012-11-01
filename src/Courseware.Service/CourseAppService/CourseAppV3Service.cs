using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.Domain;

namespace Courseware.Service
{
    public class CourseAppV3Service : ICourseAppService
    {
        // Dependency as field
        private readonly ICourseRepository _rep;

        // Bastard Injection
        //public CourseAppV3Service() : this(new SqlCourseRepository())
        //{
        //}

        // Constructor Injection
        public CourseAppV3Service(ICourseRepository rep)
        {
            if (rep == null)
                throw new ArgumentNullException("rep");

            _rep = rep;
        }

        public string GetCourseDescriptions(IEnumerable<int> courseIds)
        {
            throw new NotImplementedException();
        }
    }
}
