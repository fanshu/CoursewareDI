using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.Domain;
using Courseware.Domain.Entities;

namespace Courseware.Service
{
    public class CourseAppService : ICourseAppService
    {
        // Dependency as field
        private readonly ICourseRepository _rep;


        // Constructor Injection
        public CourseAppService(ICourseRepository rep)
        {
            if (rep == null)
                throw new ArgumentNullException("rep");

            _rep = rep;
        }

        // Service methods
        public string GetCourseDescriptions(IEnumerable<Int32> courseIds)
        {
            var sb = new StringBuilder();

            foreach (int id in courseIds)
            {
                Course c = _rep.GetById(id);

                sb.AppendLine(c.GetDescription());
            }

            return sb.ToString();
        }
    }
}
