﻿using System;
using System.Collections.Generic;
using System.Text;

namespace music.Common.Req
{
   public class PLSearchReq
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public string Id { get; set; }
        public string Keyword { get; set; }
    }
}
