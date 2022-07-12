using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectB.Models.DB
{
    public partial class TruckEmployeePb
    {
        public int EmployeeId { get; set; }
        public string OfficeAddress { get; set; }
        public string PhoneExtensionNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
