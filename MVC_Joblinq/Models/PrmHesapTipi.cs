using System;
using System.Collections.Generic;

namespace MVC_Joblinq.Models
{
    public partial class PrmHesapTipi
    {
        public PrmHesapTipi()
        {
            TblDatUsers = new HashSet<TblDatUser>();
        }

        public int Id { get; set; }
        public string? HesapTipi { get; set; }

        public virtual ICollection<TblDatUser> TblDatUsers { get; set; }
    }
}
