using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Models
{
    public class EmployeeInsurancePlan
    {
        public uint Id { get; set; }
        public Employee? Employee { get; set; }
        public uint EmployeeId { get; set; }
        public InsurancePlan? InsurancePlan { get; set; }
        public ushort InsurancePlanId { get; set; }
        public string PolicyNumber { get; set; } = string.Empty;
        public decimal MonthlyCharges { get; set; }
    }
}
