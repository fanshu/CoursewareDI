using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.Domain;
using Courseware.Domain.Entities;

namespace Courseware.Service
{
    public class CourseAppV2Service : ICourseAppService
    {
        // Dependency as field
        private readonly ICourseRepository _rep;
        private ITextFormat _formatter;

        // Property Injection
        public ITextFormat Formatter
        {
            get
            {
                // Lazy initialization
                if (this._formatter == null)
                {
                    // Local default
                    this.Formatter = new XmlTextFormat();
                }

                return this._formatter;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                if (this._formatter != null)
                    throw new InvalidOperationException("Formatter is already set");

                this._formatter = value;
            }
        }

        // Constructor Injection
        public CourseAppV2Service(ICourseRepository rep)
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

            return this.Formatter.FormatText(sb.ToString());
        }
    }
}
