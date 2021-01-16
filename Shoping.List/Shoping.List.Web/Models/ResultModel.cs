using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.List.Web.Models
{
    public class ResultModel<T>
    {
        public T Result { get; set; }
        public string ErrMessage { get; set; }
    }
}
