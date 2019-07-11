using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LuckyDream.Models
{
    public class MenuModel
    {
        public string MenuName { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string MenuType { get; set; }
    }
}