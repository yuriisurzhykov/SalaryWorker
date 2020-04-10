using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryWorker.Attributes
{
    [AttributeUsage(AttributeTargets.Class | 
                    AttributeTargets.Struct) 
    ]
    class SqlQuery : Attribute
    {
        private string main;
    }
}
