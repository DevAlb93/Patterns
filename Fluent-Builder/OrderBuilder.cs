namespace Fluent_Builder
{
    public class OrderBuilder 
    {
        private int number;
        private DateTime createdOn;
        private readonly AddressBuilder shippingAddressBuilder = AddressBuilder.Empty();
        private OrderBuilder()
        {
        }

        public static OrderBuilder Empty()
        {
            return new OrderBuilder();
        }

        public OrderBuilder WithNumber(int number)
        {
            this.number = number;
            return this;
        }

        public OrderBuilder WithCreatedOn(DateTime createdOn)
        {
            this.createdOn = createdOn;
            return this;
        }

        public OrderBuilder WithShippingAddress(Address adress)
        {

            return this;
        }

        public OrderBuilder WithShippingAdress(Action<AddressBuilder> action) 
        {
            action(shippingAddressBuilder);
            return this;
        }
        
        public Order Build()
        {
            return new Order
            {
                Number = this.number,
                CreatedOn = this.createdOn,
                ShippingAdress = shippingAddressBuilder.Build()
            };
        }
    }
} 
