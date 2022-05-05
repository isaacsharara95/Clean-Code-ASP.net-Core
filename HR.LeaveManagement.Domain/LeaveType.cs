using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain
{
    public class LeaveType:BaseDomainEntity
    {
      
        public string name { get; set; }
        public int DefaultDays { get; set; }
        

    }
}
