using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models.ViewModels
{
    public class CommonResponse<T>
    {
       public int status { get; set; }

        public string message { get; set; }
        public T dataenum { get; set; }

    }
}
