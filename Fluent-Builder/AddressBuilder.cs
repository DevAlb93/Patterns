namespace Fluent_Builder
{
    public class AddressBuilder 
    {
        private string street;
        private string city;
        private string state;
        private string zip;
        private string country;

        private AddressBuilder()
        {
        }

        public static AddressBuilder Empty()
        {
            return new AddressBuilder();
        }

        public AddressBuilder Street(string street) 
        {
            this.street = street;
            return this; 
        }
        public AddressBuilder City(string city)
        {
            this.city = city;
            return this;
        }
        public AddressBuilder State(string state )
        {
            this.state = state;
            return this;
        }
        public AddressBuilder Zip(string zip)
        {
            this.zip = zip;
            return this;
        }

        public AddressBuilder Country(string country)
        {
            this.country = country;
            return this;
        }

        public Address Build()
        {
            return new Address
            {
                Street = this.street,
                City = this.city,
                State = this.state,
                Zip = this.zip,
                Country = this.country
            };
        }

    } 
} 
