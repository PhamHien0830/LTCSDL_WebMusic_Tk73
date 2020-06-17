using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class PlaylistRep : GenericRep<DBMusicContext,Playlist>
    {
        public override Playlist Read(string MaPL)
        {
            var res = All.FirstOrDefault(p => p.MaPlayList == MaPL);
            return res;
        }
        //public string Remove(string MaPL)
        //{
        //    var m = base.All.First(i => i.MaPlayList == MaPL);
        //    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Playlist> entityEntry = Context.Playlist.Remove(m);
        //    Context.SaveChanges();
        //    return m.MaPlayList;
        //}
    }
}
