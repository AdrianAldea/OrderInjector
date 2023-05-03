using OrderInjector.DataStructures;
using OrderInjector.Interfaces;
using System.Threading.Tasks;

namespace OrderInjector.Core.Managers {
    public class OrderManager : IOrderManager {
        private IItemsProvider _itemsProvider { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public OrderManager(IItemsProvider itemsProvider) {
            _itemsProvider = itemsProvider;
        }

        public Task<string> InjectOrderAsync(Order orderToInject) {
            throw new System.NotImplementedException();
        }

        //todo - implement interface knowing that it has to call the REST API described in readme.txt file 
    }
}
