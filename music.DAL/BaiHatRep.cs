using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL
{
    using Models;
    public class BaiHatRep : GenericRep<DBMusicContext, Baihat>
    {
        #region
        public override Baihat Read(string MaID)
        {
            var res = All.FirstOrDefault(p => p.MaBaiHat == MaID);
            return res;
        }
        public string Remove(string MaBaiHat)
        {
            var m = base.All.First(i => i.MaBaiHat == MaBaiHat);
            Context.Baihat.Remove(m);
            Context.SaveChanges();
            return m.MaBaiHat;
        }
        #endregion
    }

}
