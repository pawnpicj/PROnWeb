using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCodeLibrary.Respones.SAP
{
    public class ResponseGetEmployee
    {
        public int ErrorCode { get; set; }
        public string? ErrorMsg { get; set; }
        public List<ListEmp> Data { get; set; }
    }
    public class ListEmp
    {
        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Passw0rd { get; set; }
    }
}

