// See https://aka.ms/new-console-template for more information

using Lytdybr.App.Blackbook;

for (var i = 0; i < 20; i++)
{
    var kata01 = new Kata01(100, 1_000_000);
    var result = kata01.Do();
    Console.WriteLine(result);
}