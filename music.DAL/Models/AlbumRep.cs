using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class AlbumRep : GenericRep<DBMusicContext, Album>
    {
        public override Album Read(string MaAB)
        {
            var res = All.FirstOrDefault(p => p.MaAb == MaAB);
            return res;
        }
        public string Remove(string MaAB)
        {
            var m = base.All.First(i => i.MaAB == MaAB);
            Context.Album.Remove(m);
            Context.SaveChanges();
            return m.MaAB;
        }
    }
}