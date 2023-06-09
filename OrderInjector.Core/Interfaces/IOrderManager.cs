﻿using OrderInjector.DataStructures;
using System.Threading.Tasks;

namespace OrderInjector.Interfaces {
    public interface IOrderManager {
        /// <summary>
        /// inject an order into the POS system
        /// </summary>
        /// <param name="orderToInject"></param>
        /// <returns></returns>
        Task<string> InjectOrderAsync(Order orderToInject);
    }
}
