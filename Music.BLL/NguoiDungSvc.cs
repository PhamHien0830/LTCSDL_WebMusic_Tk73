using System;
using System.Collections.Generic;
using System.Text;
using music.Common.Rsp;
using music.Common.BLL;
using music.DAL;
using music.DAL.Models;
using System.Linq;

namespace Music.BLL
{

    public class NguoiDungSvc : GenericSvc<NguoiDungRep, Nguoidung>
    {
        public override SingleRsp Read(string MaND)
        {
            var res = new SingleRsp();
            var m = _rep.Read(MaND);
            res.Data = m;
            return res;
        }
        //public override SingleRsp 
        // Search Nguoi Dung 
        public object SearchNguoiDung(string keyword, int page, int size)
        {
            var AL = All.Where(x => x.TenUser.Contains(keyword));
            var offset = (page - 1) * size;
            var total = AL.Count();
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            var data = AL.OrderBy(x => x.TenUser).Skip(offset).Take(size).ToList();
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

        // Remove 
        public SingleRsp DeleteNguoiDung(string MaND)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.Remove(MaND);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}
