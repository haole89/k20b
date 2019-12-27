using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VD_MVC.Models
{
    public class KhachMoi
    {
        public string HoTen { get; set; }
        public string Email { get; set; }

        public string SDT { get; set; }

        public bool ThamDu { get; set; }
    }
}