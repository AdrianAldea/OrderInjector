﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderInjector.Model.RestExchangedMessages
{
    public class CheckAvailabilityResponse
    {
        /// <summary>
        /// if true then Core can inject orders
        /// </summary>
        public bool CanInjectOrders { get; set; }
    }
}
