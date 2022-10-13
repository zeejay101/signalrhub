using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignallRHub.Models
{
    public class Notification
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string TranType { get; set; }
    }
}
