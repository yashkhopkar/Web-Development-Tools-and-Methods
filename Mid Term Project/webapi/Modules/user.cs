using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Modules
{
    public class User
    {

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int Health { get; set; }
        public int Food { get; set; }
        public int Wood { get; set; }
        public int Water { get; set; }
        public int ToolKit { get; set; }
    }
}
