using System;
using System.Collections.Generic;

namespace MVC_Joblinq.Models
{
    public partial class PrmSehir
    {
        public PrmSehir()
        {
            DatIlans = new HashSet<DatIlan>();
            DatSirkets = new HashSet<DatSirket>();
            TblOzlukBilgisis = new HashSet<TblOzlukBilgisi>();
            TblSirketBilgisis = new HashSet<TblSirketBilgisi>();
        }

        public int SehirId { get; set; }
        public string? SehirAdi { get; set; }

        public virtual ICollection<DatIlan> DatIlans { get; set; }
        public virtual ICollection<DatSirket> DatSirkets { get; set; }
        public virtual ICollection<TblOzlukBilgisi> TblOzlukBilgisis { get; set; }
        public virtual ICollection<TblSirketBilgisi> TblSirketBilgisis { get; set; }
    }
}
