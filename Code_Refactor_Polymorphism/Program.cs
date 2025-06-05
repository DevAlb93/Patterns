// See https://aka.ms/new-console-template for more information
using Code_Refactor_Polymorphism.NewVersion;

Console.WriteLine("Replace Conditional with Polymorphism");

double CalculateDiscount(string customerType)
{
    if (customerType == "RegularCustomer") return 0.1;
    else if (customerType == "PremiumCustomer") return 0.2;
    else return 0;
}

var discount = CalculateDiscount("RegularCustomer");
Console.WriteLine($"Calculated discount is {discount}");


// This is a better way using polymorphism
Console.WriteLine("Better way using Polymorphism");
ICustomer customer = new RegularCustomer();
double discountPolymorphism = customer.CalculateDiscount();

