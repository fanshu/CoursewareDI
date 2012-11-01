using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.Domain;
using Courseware.Domain.Entities;

namespace Courseware.DataAccess
{
    public class SqlCourseRepository : ICourseRepository
    {

        public Course GetById(int courseId)
        {
            return new Course()
            {
                CourseId = courseId,
                Name = "GE",
            };
        }

        public IEnumerable<Course> GetAll()
        {
            return new List<Course>()
            {
                new Course()
                {
                    CourseId = 201,
                    Name = "GE",
                },
                new Course()
                {
                    CourseId = 202,
                    Name = "SPIN",
                },
            };
        }

        public bool Update(Course c)
        {
            Course ori = this.GetById(c.CourseId);
            ori.Name = c.Name;

            return true;
        }

        public bool Remove(Course c)
        {
            throw new NotImplementedException();
        }
    }
}
