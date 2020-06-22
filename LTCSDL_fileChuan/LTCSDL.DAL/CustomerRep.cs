
using LTCSDL.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using LTCSDL.Common.DAL;
using System.Linq;

namespace LTCSDL.DAL
{
    using LTCSDL.Common.Rsp;
    using LTCSDL.DAL.Model1;

    public class CustomerRep : GenericRep<WeebAdsContext, Customers>
    {
        #region --Overrides--
        public override Customers Read(int id)
        {
            var res = All.FirstOrDefault(p => p.IdC == id);
            return res;
        }
        public int Remove(int id)
        {
            var m = base.All.First(i => i.IdC == id);
            m = base.Delete(m);
            return m.IdC;
        }
        #endregion
        public SingleRsp CreateCustomer(Customers ctm) {
            var res = new SingleRsp();
            using (var context = new WeebAdsContext()) {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Customers.Add(ctm);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;

        }
        public SingleRsp DeleteCustomer(Customers ctm)
        {
            var res = new SingleRsp();
            using (var context = new WeebAdsContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Customers.Remove(ctm);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        res.SetError(ex.StackTrace);
                    }
                }
            }
            return res;

        }
    }

}
