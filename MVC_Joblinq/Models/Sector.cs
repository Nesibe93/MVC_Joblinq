using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MVC_Joblinq.Models
{
    public partial class Sector
    {
        public byte SectorId { get; set; }
        [DisplayName("Sektör Adı")]
        public string? SectorName { get; set; }
    }
}
