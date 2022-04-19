using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business
{
    public class OrderProcessor
    {
        public delegate void OrderInitialized();

        public OrderInitialized OnOrderInitialized { get; set; }

        private void Initialize(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);
        }

        public void Process(Order order)
        {
            Initialize(order);
        }
    }
}