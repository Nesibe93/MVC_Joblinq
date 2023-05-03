using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Joblinq.Models
{
    public partial class User
    {
        public int UserId { get; set; }

        [DisplayName("Kullanıcı Maili")]
        public string? UserEmail { get; set; }

        [DisplayName("Kullanıcı Şifresi")]
        public string? UserPassword { get; set; }

        [DisplayName("Kullanıcı Tipi")]
        public string? UserType { get; set; }
    }
}
