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
    public class MusicController : ControllerBase
    {
        public MusicController()
        {
            _svc = new BaiHatSvc();
        }
        [HttpPost("get-by-MaBaiHat")]
        public IActionResult getMusicByMaBaiHat([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Keyword);
            return Ok(res);
        }
        [HttpPost("SearchBaiHat")]
        public IActionResult SearchBaiHat([FromBody] BHSearchReq req)
        {
            var res = new SingleRsp();
            var pros = _svc.SearchBaiHat(req.Keyword, req.Page, req.Size);
            res.Data = pros;
            return Ok(res);
        }
        [HttpPost("Delete-MaBaiHat")]
        public IActionResult DeleteBaiHat(BHDeleteReq req)
        {
            var res = _svc.DeleteBaiHat(req.MaBaiHat);
            return Ok(res);
        }

        private readonly BaiHatSvc _svc;
    }
}