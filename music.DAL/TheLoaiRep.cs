using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class TheLoaiRep : GenericRep<DBMusicContext, Theloai>
    {
        public override Theloai Read(string MaTL)
        {
            var res = All.FirstOrDefault(p => p.MaTheLoai == MaTL);
            return res;
        }
        public string Remove(string MaTL)
        {
            var m = base.All.First(i => i.MaTheLoai == MaTL);
            Context.Theloai.Remove(m);
            Context.SaveChanges();
            return m.MaTheLoai;
        }
    }
}

