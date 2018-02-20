﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Legendary_Student_API.Models.Helper
{
    public class DataModel
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public object Data { get; set; }
        public HttpException Exception { get; set; }
    }
}