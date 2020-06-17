using System;
using System.Collections.Generic;
using System.Text;
using music.Common.Rsp;
using music.Common.BLL;
using music.DAL;
using music.DAL.Models;
using System.Linq;

// public class PlayListSvc : GenericSvc<PlayListRep, Playlist>
namespace Music.BLL
{

    public class PlaylistSvc : GenericSvc<PlaylistRep, Playlist>
    {
        public override SingleRsp Read(string MaPL)
        {
            var res = new SingleRsp();
            var m = _rep.Read(MaPL);
            res.Data = m;
            return res;
        }
        //public override SingleRsp 
        // Search
        public object SearchPlayList(string keyword, int page, int size)
        {
            var AL = All.Where(x => x.TenPlaylist.Contains(keyword));
            var offset = (page - 1) * size;
            var total = AL.Count();
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            var data = AL.OrderBy(x => x.TenPlaylist).Skip(offset).Take(size).ToList();
            var res = new
            {
                Data = data,
                totalRecord = total,
                TotalPage = totalPage,
                page = page,
                size = size
            };
            return res;
        }
        //        // Remove 
        //        public SingleRsp DeletePlaylist(string MaPlayList)
        //        {
        //            var res = new SingleRsp();
        //            try
        //            {
        //                res.Data = _rep.Remove(MaPlayList);
        //            }
        //            catch (Exception ex)
        //            {
        //                res.SetError(ex.StackTrace);
        //            }
        //            return res;
        //        }

    }
}
