using System;
using System.Collections.Generic;

namespace music.DAL.Models
{
    public partial class Albumbaihat
    {
        public string Ma { get; set; }
        public string MaAb { get; set; }
        public string MaBh { get; set; }
        public string GhiChu { get; set; }

        public virtual Album MaAbNavigation { get; set; }
        public virtual Baihat MaBhNavigation { get; set; }
    }
}
