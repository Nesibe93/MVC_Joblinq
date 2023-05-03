using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MVC_Joblinq.Models
{
    public partial class Candidate
    {
        public int CandidateId { get; set; }

        [DisplayName("Kullanıcı Adı")]
        public int? UserId { get; set; }

        [DisplayName("Adı")]
        public string? Fname { get; set; }

        [DisplayName("Soyadı")]
        public string? Lname { get; set; }

        [DisplayName("Doğum Tarihi")]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Şehir")]
        public byte? CityId { get; set; }

        [DisplayName("Telefon No")]
        public string? Gsmno { get; set; }
    }
}
