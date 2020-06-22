using System;
using System.Collections.Generic;
using System.Text;
using LTCSDL.Common.DAL;
using System.Linq;

namespace LTCSDL.DAL
{
    using LTCSDL.DAL.Models;
    public class CategoriesRep : GenericRep<NorthwindContext, Categories>
    {
        #region --Overrides--
        public override Categories Read(int id)
        {
            var res = All.FirstOrDefault(p => p.CategoryId == id);
            return res; 
        }
        public int Remove(int id) 
        {
            var m = base.All.First(i => i.CategoryId == id);
            m = base.Delete(m);
            return m.CategoryId;
        }
        #endregion
    }
}
