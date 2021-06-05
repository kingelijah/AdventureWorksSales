﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorksSales.Web.Models
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}