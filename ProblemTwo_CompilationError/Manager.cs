using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager
    {
        public static object eLevel;
        public static object eName;
        public static object eID;
        public static object eDoJ;

        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }
        public int V1 { get; }
        public string V2 { get; }
        public int V3 { get; }
        public DateTime DateTime { get; }
        public List<Employee> LstDirectReports { get; }
        public string V4 { get; }

        public Manager(List<Employee> drEmployeesLst, string cCode) : base(eID, eName, eLevel, eDoJ)
        {
            DirectReports = drEmployeesLst;
            CostCode = cCode;

        }

        public Manager(int v1, string v2, int v3, DateTime dateTime, List<Employee> lstDirectReports, string v4)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            DateTime = dateTime;
            LstDirectReports = lstDirectReports;
            V4 = v4;
        }

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}
