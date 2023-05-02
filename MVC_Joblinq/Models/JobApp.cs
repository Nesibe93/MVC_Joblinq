using System;
using System.Collections.Generic;

namespace MVC_Joblinq.Models
{
    public partial class JobApp
    {
        public int JobAppId { get; set; }
        public int? UserId { get; set; }
        public int? AdvertId { get; set; }
    }
}
