using System;
using System.Collections.Generic;

namespace MVC_Joblinq.Models
{
    public partial class DatSirket
    {
        public DatSirket()
        {
            DatIlans = new HashSet<DatIlan>();
        }

        public int SirketId { get; set; }
        public int? UserId { get; set; }
        public string? SirketAdi { get; set; }
        public int? SektorId { get; set; }
        public string? SirketAdres { get; set; }
        public int? SehirId { get; set; }

        public virtual PrmSehir? Sehir { get; set; }
        public virtual PrmSektorBilgisi? Sektor { get; set; }
        public virtual DatUser? User { get; set; }
        public virtual ICollection<DatIlan> DatIlans { get; set; }
    }
}
