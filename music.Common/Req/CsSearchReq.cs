using System;
using System.Collections.Generic;
using System.Text;

namespace music.Common.Req
{
    public class CsSearchReq
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public string Id { get; set; }
        public string Keyword { get; set; }
    }

}
