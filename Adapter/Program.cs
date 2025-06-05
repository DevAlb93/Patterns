// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Adapter Pattern");
var adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"City: {city.FullName}, Inhabitants: {city.Inhabitants}");
Console.ReadLine();
