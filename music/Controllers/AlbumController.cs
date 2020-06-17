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
    public class AlbumController : ControllerBase
    {
        public AlbumController()
        {
            _svc = new AlbumSvc();
        }
        //
        [HttpPost("get-by-MaAlbum")]
        public IActionResult getMusicMaAlbum([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = _svc.Read(req.Keyword);
            return Ok(res);
        }
        //
        [HttpPost("SearchAlbum")]
        public IActionResult SearchAlbum([FromBody] ABSearchReq req)
        {
            var res = new SingleRsp();
            var pros = _svc.SearchAlbum(req.Keyword, req.Page, req.Size);
            res.Data = pros;
            return Ok(res);
        }
        //
        [HttpPost("Delete-MaAlbum")]
        public IActionResult DeleteAlbum(ABDeleteReq req)
        {
            var res = _svc.DeleteAlbum(req.MaAB);
            return Ok(res);
        }

        private readonly AlbumSvc _svc;
    }
}