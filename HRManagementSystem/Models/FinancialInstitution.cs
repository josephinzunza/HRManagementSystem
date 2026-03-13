using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Models
{
    public class FinancialInstitution
    {
        public byte Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RoutingNumber { get; set; } = string.Empty;
    }
}
