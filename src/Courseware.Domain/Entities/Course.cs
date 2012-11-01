using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Courseware.Domain.Entities
{
    public class Course
    {
        // Entity fields

        public int CourseId { get; set; }

        public string Name { get; set; }


        // Entity methods

        public string GetDescription()
        {
            return String.Format("Course: {0} - {1}", this.CourseId, this.Name);
        }

    }
}
