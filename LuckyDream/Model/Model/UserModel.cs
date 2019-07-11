using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public List<string> ListPermission { get; set; }

        public UserModel()
        {
            this.UserId = 1;
            this.UserName = "test 1";
            this.ListPermission.Add("Home");
        }
    }
}
