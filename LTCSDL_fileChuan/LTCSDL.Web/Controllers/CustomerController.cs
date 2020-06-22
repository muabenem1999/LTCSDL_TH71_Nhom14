using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LTCSDL.BLL;
using LTCSDL.Common.Req;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LTCSDL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController() {
            _svc = new CustomerSvc();
        }

        [HttpPost("create-customer")]
        public IActionResult CreateCustomer([FromBody] CustomerReq req)
        {
            var res = _svc.CreateCustomer(req);
            return Ok(res);
        }

        [HttpPost("detele-customer")]
        public IActionResult DeleteCustomer([FromBody] CustomerReq req)
        {
            var res = _svc.DeleteCustomer(req.IdC);
            return Ok(res);
        }


        private readonly CustomerSvc _svc;
    }
}
