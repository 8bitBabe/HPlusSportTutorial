using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSportAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { set; get; }
        public virtual List<Order> Orders { get; set; }
    }
}
