﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrderInjector.DataStructures
{
    public class Order
    {
        /// <summary>
        /// list of all items of an order
        /// </summary>
        public List<OrderedItem> OrderItems { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public Order()
        {
            OrderItems = new List<OrderedItem>();
        }
    }
}
