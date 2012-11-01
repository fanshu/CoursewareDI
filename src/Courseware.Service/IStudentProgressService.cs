using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Courseware.Service
{
    public interface IStudentProgressService
    {
        string GetStudentProgress(int studentId, IStudentContext context);

        string GetStudentProgressV2(int studentId);
    }
}
