using LTCSDL.Common.DAL;
using LTCSDL.DAL.Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LTCSDL.DAL
{
    public class RequestRep : GenericRep<WeebAdsContext,Request>
    {
        #region --Overrides--
        public override Request Read(int id)
        {
            var res = All.FirstOrDefault(p => p.Idreqs == id);
            return res;
        }
        public int Remove(int id)
        {
            var m = base.All.First(i => i.Idreqs == id);
            m = base.Delete(m);
            return m.Idreqs;
        }
        #endregion
    }
}
