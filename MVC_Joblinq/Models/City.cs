using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MVC_Joblinq.Models
{
    public partial class City
    {
        public byte CityId { get; set; }
        [DisplayName("Şehir Adı")]
        public string? CityName { get; set; }
    }
}
