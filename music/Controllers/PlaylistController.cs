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
    public class PlaylistController : ControllerBase
    {
        public PlaylistController()
        {
            _svc = new PlaylistSvc();
        }
        [HttpPost("get-by-MaPlayList")]
        public IActionResult getPlayList([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Keyword);
            return Ok(res);
        }
        [HttpPost("SearchPlayList")]
        public IActionResult SearchPlayList([FromBody] PLSearchReq req)
        {
            var res = new SingleRsp();
            var pros = _svc.SearchPlayList(req.Keyword, req.Page, req.Size);
            res.Data = pros;
            return Ok(res);
        }
        //[HttpPost("Delete-MaPlayList")]
        //public IActionResult DeletePlayList([FromBody] PLDeleteReq req)
        //{
        //    var res = _svc.DeletePlaylist(req.MaPlayList);
        //    return Ok(res);
        //}

        private readonly PlaylistSvc _svc;
    }
}