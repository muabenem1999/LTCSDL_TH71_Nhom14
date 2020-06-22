using LTCSDL.Common.DAL;
using LTCSDL.DAL.Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTCSDL.DAL
{
    public class searchCustomerRep: GenericRep<WeebAdsContext, Customers>
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
    }
}
