// See https://aka.ms/new-console-template for more information
//Top level statements
//Global namespace
//Global using directives
//Implicit usings

using CSharp8;
using CSharp8.Enums;

Console.WriteLine("Hello, World!");

var currency = CurrencyHelper.GetCurrencyText(Currency.NZD);
Console.WriteLine(currency);

Console.ReadKey();
