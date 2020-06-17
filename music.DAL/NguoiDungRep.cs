using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class NguoiDungRep : GenericRep<DBMusicContext, Nguoidung>
    {
        public override Nguoidung Read(String MaND)
        {
            var res = All.FirstOrDefault(b => b.MaUser == MaND);
            return res;
        }
        public string Remove(string MaND)
        {
            var m = base.All.First(i => i.MaUser == MaND);
            Context.Nguoidung.Remove(m);
            Context.SaveChanges();
            return m.MaUser;
        }
    }
}