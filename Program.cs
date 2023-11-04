using ConsoleApp26.DataEntity;
    
  
using ErpContext erp = new ();

var q =
    from c in erp.StateInfos
    join pt in erp.Countries on c.CountryId equals pt.Id into ps_jointable
    from p in ps_jointable.DefaultIfEmpty()
    select new { country = p.Country1, stated = c.StateName };

foreach(var d in q)
{
    Console.WriteLine(d.stated + " " + d.country);

}


//var joindata = erp.Countries.Join(erp.StateInfos, y => y.Id, p => p.CountryId, (y, p) =>
//new {
//    CountryName = y.Country1,
//    StateName = p.StateName

//}).ToList();


//foreach (var item in joindata)
//{
//    Console.WriteLine(item.StateName +  " " + item.CountryName);
//}




//var d = erp.Accounts.GroupBy(y => y.AccountName).Select(y =>
//new
//{
//    Name = y.Key,
//    values = y

//});


//foreach(var t in d)
//{
//    Console.WriteLine(t.Name + " " + t.values);

   

//}

//var p = from a in erp.Accounts
//        where a.AccountName.Contains("test") == true
//        select a;




//foreach (var account in d)
//{
//    Console.WriteLine(account.AccountName);
//}

