using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mosesbox_fit.Models
{
    public class Result
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Error { get; set; }
    }
}
