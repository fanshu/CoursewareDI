using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Courseware.Service
{

    // Local default implementation of ITextFormat
    public class XmlTextFormat : ITextFormat
    {
        public string FormatText(string input)
        {
            return String.Format("<root>{0}</root>", input);
        }
    }
}
