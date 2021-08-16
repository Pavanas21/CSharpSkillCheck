using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport
    {
        private int v1;
        private string v2;
        private int v3;
        private DateTime dateTime;
        private object p;
        private string v4;

        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(Employee managerEmpObj,string pCode) :base(eID,eName,eLevel,eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }

        public DirectReport(int v1, string v2, int v3, DateTime dateTime, object p, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.dateTime = dateTime;
            this.p = p;
            this.v4 = v4;
        }
    }
}
