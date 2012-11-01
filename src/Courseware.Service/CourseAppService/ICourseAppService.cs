using System;
namespace Courseware.Service
{
    public interface ICourseAppService
    {
        string GetCourseDescriptions(System.Collections.Generic.IEnumerable<int> courseIds);
    }
}
