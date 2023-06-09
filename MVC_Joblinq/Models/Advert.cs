﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MVC_Joblinq.Models
{
    public partial class Advert
    {
        public int AdvertId { get; set; }
        [DisplayName("Şirket ID")] // DB deki tablo alanının nasıl görünmesini istiyorsak [DisplayName("...")] kullanıyoruz
        public int? CompanyId { get; set; }

        [DisplayName("İlan Başlığı")]
        public string? AdvertTitle { get; set; }

        [DisplayName("İlan Detayı")]
        public string? AdvertDetail { get; set; }

        [DisplayName("Şehir ID")]
        public byte? CityId { get; set; }

        [DisplayName("İş Tipi")]
        public string? JobType { get; set; }
    }
}
