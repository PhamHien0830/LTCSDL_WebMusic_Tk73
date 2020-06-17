using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    ////public class CaSiRep : GenericRep<DBMusicContext, Casi>
    ////{
    ////    public override Casi Read(String MaCs)
    ////    {
    ////        var res = All.FirstOrDefault(b => b.MaCaSi == MaCs);
    ////        return res;
    ////    }
        public class CaSiRep : GenericRep<DBMusicContext, Casi>
        {
            #region
            public override Casi Read(string MaCaSi)
            {
                var res = All.FirstOrDefault(p => p.MaCaSi == MaCaSi);
                return res;
            }

            public string Remove(string MaCaSi)
        {
            var m = base.All.First(i => i.MaCaSi == MaCaSi);
            Context.Casi.Remove(m);
            Context.SaveChanges();
            return m.MaCaSi;
        }
        #endregion
    }
}
