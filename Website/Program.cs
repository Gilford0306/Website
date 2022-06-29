

using Website;

Site site1 = new Site("site1", "www.site1.com", "Description1", "192.168.1.1");
Console.WriteLine(site1);
Console.WriteLine("==================");
site1.Url = "www.newsite1.com";
Console.WriteLine(site1.Url);