﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp3.Models
{
    public class Response
    {
        public bool IsSucess { get; set; }

        public string Message { get; set; }

        public object Result { get; set; }
    }
}