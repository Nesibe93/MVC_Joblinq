using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MVC_Joblinq.Models
{
    public partial class JobApp
    {
        public int JobAppId { get; set; }

        [DisplayName("User ID")]
        public int? UserId { get; set; }

        [DisplayName("İlan ID")]
        public int? AdvertId { get; set; }
    }
}
