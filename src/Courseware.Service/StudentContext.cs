using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Courseware.Service
{
    public abstract class StudentContext
    {
        public static StudentContext Current
        {
            get
            {
                var ctx = Thread.GetData(Thread.GetNamedDataSlot("StudentContext")) as StudentContext;
                if (ctx == null)
                {
                    ctx = StudentContext.Default;
                    Thread.SetData(Thread.GetNamedDataSlot("StudentContext"), ctx);
                }

                return ctx;
            }
            set
            {
                Thread.SetData(Thread.GetNamedDataSlot("StudentContext"), value);
            }
        }

        // Local default
        public static StudentContext Default = new DefaultStudentContext();

        public abstract string LanguageCode { get; }
    }
}
