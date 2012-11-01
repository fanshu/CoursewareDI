using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace Courseware.Service
{
    public class StudentProgressService : IStudentProgressService
    {
        public string GetStudentProgress(int studentId, IStudentContext context)
        {
            return String.Format("Student: {0} - Good in {1}", new CultureInfo(context.Language), context.Language);

        }

        public string GetStudentProgressV2(int studentId)
        {
            return String.Format("Student Progress: {0} - Good in {1}",
                new CultureInfo(StudentContext.Current.LanguageCode),
                StudentContext.Current.LanguageCode);

        }
    }
}
