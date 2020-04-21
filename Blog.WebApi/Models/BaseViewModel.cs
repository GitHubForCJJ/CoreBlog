using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApi.Models
{
    public class BaseViewModel
    {
        public int KID { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public string Num { get; set; }
    }
}
