using OrderInjector.DataStructures;
using OrderInjector.Interfaces;
using System.Collections.Generic;

namespace OrderInjector.Providers {
    /// <summary>
    /// class providing the list of items as retrieved from POS system
    /// </summary>
    public class ItemsProvider : IItemsProvider {
        private List<POSItem> _posItems;

        public List<POSItem> AllPOSItems => _posItems;

        public List<POSItem> AvailablePOSItems => throw new System.NotImplementedException();

        /// <summary>
        /// constructor
        /// </summary>
        public ItemsProvider() {
            _posItems = new List<POSItem>();
            LoadItemsFromPOS();
        }

        /// <summary>
        /// retrieving items from POS is a simple parse of a json
        /// </summary>
        public void LoadItemsFromPOS() {
            //todo - implement the code to load items from Data\ContentItems.json file
        }

        //todo - implement missing methods of interface
    }
}
