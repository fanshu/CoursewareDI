using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Courseware.Domain
{
    public interface IStudentProgressRepository
    {
        string GetStudentProgress(int studentId);
    }
}
