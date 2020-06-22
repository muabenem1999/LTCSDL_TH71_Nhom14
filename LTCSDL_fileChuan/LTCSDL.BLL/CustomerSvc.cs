using LTCSDL.Common.DAL;
using LTCSDL.Common.Rsp;
using System;
using System.Collections.Generic;
using System.Text;
using LTCSDL.Common.BLL;

namespace LTCSDL.BLL
{
    using DAL;
    using DAL.Model1;
    using LTCSDL.Common.Req;

    public class CustomerSvc : GenericSvc<CustomerRep, Customers>
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

        public SingleRsp CreateCustomer(CustomerReq ctm) {
            var res = new SingleRsp();
            Customers customers = new Customers();
            customers.FullName = ctm.FullName;
            customers.Email = ctm.Email;
            customers.Phone = ctm.Phone;
            res = _rep.CreateCustomer(customers);
            return res;
        }
        public SingleRsp DeleteCustomer(int id)
        {
            var res = new SingleRsp();
            Customers customers = new Customers { IdC = id };
            res = _rep.DeleteCustomer(customers);
            return res;
        }
      

    }
    

}
