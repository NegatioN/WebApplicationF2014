﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebAppH2014.Models
{
    public class OrderSalesItem
    {
        //used in many to many relation database for letting us know how many of a given item the customer ordered.

        public int OrderSalesItemId { get; set; }
        public SalesItem SalesItem { get; set; }
        public Order Order { get; set; }
        public int Amount { get; set; }

    }
}