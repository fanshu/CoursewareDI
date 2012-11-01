using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Courseware.Domain;

namespace Courseware.Service
{
    public class StudentProgressConstrainedConstructorService : IStudentProgressService
    {
        private readonly IStudentProgressRepository _rep;

        public StudentProgressConstrainedConstructorService(IStudentProgressRepository rep)
        {
            _rep = rep;
        }

        public string GetStudentProgress(int studentId, IStudentContext context)
        {
            return _rep.GetStudentProgress(studentId);
        }

        public string GetStudentProgressV2(int studentId)
        {
            return _rep.GetStudentProgress(studentId);
        }
    }
}
