using OrderInjector.DataStructures;

namespace OrderInjector.Model.RestExchangedMessages {
    public class InjectOrderRequest {
        public Order Order { get; set; }
        public Customer Customer { get; set; }
    }
}
