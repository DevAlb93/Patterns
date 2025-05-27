// See https://aka.ms/new-console-template for more information
using Fluent_Builder;

Console.WriteLine("Implementing Fluent Validation");

var result = OrderBuilder.Empty()
    .WithNumber(1)
    .WithCreatedOn(DateTime.UtcNow)
    .WithShippingAdress(b =>
    b.Street("Main Street")
         .City("Springfield")
         .State("IL")
         .Zip("62701"))
    .Build();

Console.WriteLine(result);