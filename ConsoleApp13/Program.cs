using ConsoleApp13;
using EFCore.BulkExtensions;

//using var context = new MarketingContext();
using var context = new MartekingMysqlContext();

//var list = new GerarLista().GerarListaMarketing();
var list = await new GerarLista().Lista2();

//context.Marketings.Add(std);
//context.SaveChanges();
//context.Truncate<Marketing>();
context.BulkInsert(list);



Console.ReadLine();