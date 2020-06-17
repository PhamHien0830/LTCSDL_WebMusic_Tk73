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
    public class TheLoaiController : ControllerBase
    {
        public TheLoaiController()
        {
            _svc = new TheLoaiSvc();
        }
        [HttpPost("get-by-MaTheLoai")]
        public IActionResult getMaTheLoai([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Keyword);
            return Ok(res);
        }
        [HttpPost("SearchTheLoai")]
        public IActionResult SearchTheLoai([FromBody] TLSearchReq req)
        {
            var res = new SingleRsp();
            var pros = _svc.SearchTheLoai(req.Keyword, req.Page, req.Size);
            res.Data = pros;
            return Ok(res);
        }

        [HttpPost("Delete-MaTheLoai")]
        public IActionResult DeleteTheLoai([FromBody] TLDeleteReq req)
        {
            var res = _svc.DeleteTheLoai(req.MaTheLoai);
            return Ok(res);
        }

        private readonly TheLoaiSvc _svc;
    }
}