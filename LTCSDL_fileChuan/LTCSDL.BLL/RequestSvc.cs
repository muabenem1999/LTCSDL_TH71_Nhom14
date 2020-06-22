using LTCSDL.Common.BLL;
using LTCSDL.Common.Rsp;
using LTCSDL.DAL;
using LTCSDL.DAL.Model1;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Aspose.Pdf.Operators;

namespace LTCSDL.BLL
{
    public class RequestSvc : GenericSvc<CustomerRep, Customers>
    {
        #region -- Overrides --

        /// <summary>
        /// Read single object
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Return the object</returns>
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="m">The model</param>
        /// <returns>Return the result</returns>
         #endregion
        public object SearchRequest()
        {
            var xs = new WeebAdsContext();
            var Re = xs.Request.ToList();
            return Re;
        }
    }
    
}

