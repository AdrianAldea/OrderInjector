using OrderInjector.DataStructures;
using System.Collections.Generic;

namespace OrderInjector.Interfaces {
    public interface IItemsProvider {
        /// <summary>
        /// list of all POS items
        /// </summary>
        List<POSItem> AllPOSItems { get; }

        /// <summary>
        /// list of all POS items that are available
        /// </summary>
        List<POSItem> AvailablePOSItems { get; }
    }
}
