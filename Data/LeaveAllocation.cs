using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Data
{
    public class LeaveAllocation
    {
        [Key]
        public int Id { get; set; }
        public int NoOfDays { get; set; }
        public DateTime DateCreated { get; set; }

       //adding the Employee reference so that the system understands that leave allocation and leave type is for the employee
       [ForeignKey ("EmployeeId")]
       public Employee  Employee { get; set; }
       public string EmployeeId { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
       public int LeaveTypeId { get; set; }
         

    }
}
