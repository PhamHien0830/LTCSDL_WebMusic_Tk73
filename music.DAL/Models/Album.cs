using System;
using System.Collections.Generic;

namespace music.DAL.Models
{
    public partial class Album
    {
        public Album()
        {
            Albumbaihat = new HashSet<Albumbaihat>();
        }

        public string MaAb { get; set; }
        public string MaAB { get; internal set; }
        public string TenAb { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<Albumbaihat> Albumbaihat { get; set; }
    }
}
