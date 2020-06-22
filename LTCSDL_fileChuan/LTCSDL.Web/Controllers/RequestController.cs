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
    public class RequestController : ControllerBase
    {
        public RequestController()
        {
            _svc = new RequestSvc();
        }
        [HttpPost("get-all")]
        public IActionResult CreateCustomer([FromBody] searchRequest req)
        {
            var res = new SingleRsp();
            var reqq = _svc.SearchRequest();
            res.Data = reqq;
            return Ok(res);
        }
        private readonly RequestSvc _svc;
    }
}
