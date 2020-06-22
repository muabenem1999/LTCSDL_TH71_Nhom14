using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTCSDL.BLL;
using LTCSDL.Common.Req;
using LTCSDL.Common.Rsp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LTCSDL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class searchCustomerController : ControllerBase
    {
        public searchCustomerController()
        {
            _svc = new searchCustomerSvc();
        }

        [HttpPost("get-all-customer")]
        public IActionResult CreatesearchCustomer([FromBody] searchCustomerReq req)
        {
            var res = new SingleRsp();
            var reqq = _svc.SearchCustomer();
            res.Data = reqq;
            return Ok(res);
        }
        private readonly searchCustomerSvc _svc;
    }
}
