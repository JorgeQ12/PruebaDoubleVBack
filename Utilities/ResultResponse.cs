using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Utilities
{
    public class ResultResponse<T>
    {
        public bool IsSucces { get; set; }
        public T Data { get; set; }

        public ResultResponse(bool isSucces, T data)
        {
            IsSucces = isSucces;
            Data = data;
        }
    }
}
