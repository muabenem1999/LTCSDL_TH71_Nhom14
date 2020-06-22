using System;
using System.Collections.Generic;
using System.Text;

namespace LTCSDL.Common.Req
{
    public class CustomerReq
    {
        public int IdC { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public decimal Phone { get; set; }
    }
}
