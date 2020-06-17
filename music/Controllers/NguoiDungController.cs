using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace music.Controllers
{
    using Music.BLL;
    using music.DAL.Models;
    using Common.Req;
    using Common.Rsp;
    [Route("api/[controller]")]
    [ApiController]
    public class NguoiDungController : ControllerBase
    {
        public NguoiDungController()
        {
            _svc = new NguoiDungSvc();
        }
        [HttpPost("get-by-MaUser")]
        public IActionResult getNguoiDung([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Keyword);
            return Ok(res);
        }
        //
        [HttpPost("SearchNguoiDung")]
        public IActionResult SearchNguoiDung([FromBody] NDSearchReq req)
        {
            var res = new SingleRsp();
            var pros = _svc.SearchNguoiDung(req.Keyword, req.Page, req.Size);
            res.Data = pros;
            return Ok(res);
        }
        //
        [HttpPost("Delete-MaUser")]
        public IActionResult DeleteNguoiDung([FromBody] NDDeleteReq req)
        {
            var res = _svc.DeleteNguoiDung(req.MaUser);
            return Ok(res);
        }

        private readonly NguoiDungSvc _svc;
    }
}