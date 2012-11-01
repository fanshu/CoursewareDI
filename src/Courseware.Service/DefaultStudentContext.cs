using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Courseware.Service
{
    public class DefaultStudentContext : StudentContext
    {
        public override string LanguageCode
        {
            get { return "en-us"; }
        }
    }
}
