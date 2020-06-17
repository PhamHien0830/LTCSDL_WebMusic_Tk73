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

    public class CaSiSvc : GenericSvc<CaSiRep, Casi>
    {
        public override SingleRsp Read(string MaCaSi)
        {
            var res = new SingleRsp();
            var m = _rep.Read(MaCaSi);
            res.Data = m;
            return res;
        }
        //public override SingleRsp 
        // Search casi
        public object SearchCaSi(string keyword, int page, int size)
        {
            var CS = All.Where(x => x.TenCaSi.Contains(keyword));
            var offset = (page - 1) * size;
            var total = CS.Count();
            int totalPage = (total % size) == 0 ? (int)(total / size) : (int)((total / size) + 1);
            var data = CS.OrderBy(x => x.TenCaSi).Skip(offset).Take(size).ToList();
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
        public SingleRsp DeleteCasi(string MaCaSi)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.Remove(MaCaSi);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }
    }
}