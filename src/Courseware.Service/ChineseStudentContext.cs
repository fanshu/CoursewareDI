using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Courseware.Service
{
    public class ChineseStudentContext : StudentContext
    {
        public override string LanguageCode
        {
            get { return "zh-cn"; }
        }
    }
}
