using System;
using System.Collections.Generic;

namespace MVC_Joblinq.Models
{
    public partial class DatUser
    {
        public DatUser()
        {
            DatOzluks = new HashSet<DatOzluk>();
            DatSirkets = new HashSet<DatSirket>();
            JnkBasvurus = new HashSet<JnkBasvuru>();
        }

        public int UserId { get; set; }
        public string? UserEmail { get; set; } // Databasedeki boş olabilir seçili değilse
        public string? UserPassword { get; set; }
        public string? UserAccountType { get; set; }

        public virtual ICollection<DatOzluk> DatOzluks { get; set; }
        public virtual ICollection<DatSirket> DatSirkets { get; set; }
        public virtual ICollection<JnkBasvuru> JnkBasvurus { get; set; }
    }
}
