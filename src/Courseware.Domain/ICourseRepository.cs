using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.Domain.Entities;

namespace Courseware.Domain
{
    public interface ICourseRepository
    {
        Course GetById(int courseId);

        IEnumerable<Course> GetAll();

        bool Update(Course c);

        bool Remove(Course c);
    }
}
