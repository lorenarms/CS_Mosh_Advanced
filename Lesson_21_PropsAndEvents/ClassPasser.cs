using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21_PropsAndEvents
{
    public class ClassPasser
    {
        public Object ClassToPass { get; private set; }

        public ClassPasser(Object classToPass)
        {
            ClassToPass = classToPass;
        }
    }
}
