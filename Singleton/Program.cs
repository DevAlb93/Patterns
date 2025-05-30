// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Testing SingletonPattern");

var singleton = Logger.GetInstance;
singleton.Log("This is a log message from the singleton instance.");
Console.ReadLine(); 
