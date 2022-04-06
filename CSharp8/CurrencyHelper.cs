// See https://aka.ms/new-console-template for more information
//Top level statements
//Global namespace
//Global using directives
//Implicit usings

using CSharp8.Enums;

namespace CSharp8
{
    public class CurrencyHelper
    {
        public static string GetCurrencyText(Currency currency)
        {
            return currency switch
            {
                Currency.USD => "United States Dollar", 
                Currency.ARS => "Argintenian Peso",
                Currency.IDR => "Indonesian Rupiah",
                Currency.CAD => "Canadian Dollar",
                Currency.GBP => "British Pound", 
                Currency.NZD => "New Zealand Dollar",
                _ => throw new ArgumentOutOfRangeException(nameof(currency), $"Unexpected currency ticker: {currency}"),
            };
        }
    }
}