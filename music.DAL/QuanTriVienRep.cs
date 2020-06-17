using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class QuanTriVienRep : GenericRep<DBMusicContext, Quantrivien>
    {
        public override Quantrivien Read(String MaQT)
        {
            var res = All.FirstOrDefault(b => b.MaQuanTri == MaQT);
            return res;
        }
        public string Remove(string MaQT)
        {
            var m = base.All.First(i => i.MaQuanTri == MaQT);
            Context.Quantrivien.Remove(m);
            Context.SaveChanges();
            return m.MaQuanTri;
        }
    }
}

