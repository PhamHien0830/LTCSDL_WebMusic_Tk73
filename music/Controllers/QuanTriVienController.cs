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
    public class QuanTriVienController : ControllerBase
    {
        public QuanTriVienController()
        {
            _svc = new QuanTriVienSvc();
        }
        [HttpPost("get-by-MaQuanTri")]
        public IActionResult getMaQuanTri([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Keyword);
            return Ok(res);
        }
        //
        [HttpPost("SearchQuanTriVien")]
        public IActionResult SearchQuanTri([FromBody] QTSearchReq req)
        {
            var res = new SingleRsp();
            var pros = _svc.SearchQuanTri(req.Keyword, req.Page, req.Size);
            res.Data = pros;
            return Ok(res);
        }
        //
        [HttpPost("Delete-MaQuanTriVien")]
        public IActionResult DeleteQuanTriVien([FromBody] QTDeleteReq req)
        {
            var res = _svc.DeleteQuanTriVien(req.MaQuanTri);
            return Ok(res);
        }

        private readonly QuanTriVienSvc _svc;
    }
}