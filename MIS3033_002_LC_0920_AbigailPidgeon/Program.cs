// MIS 3033 002
// September 20, 2023
// Abigail Pidgeon 113515288

using a;
using System.Text.Json;

Console.WriteLine("City Database");

CityDB db;
db = new CityDB();// create the database connection

string r; // result string 
string filepath = "data.json";

var opt = new JsonSerializerOptions();
opt.WriteIndented = true;

{ 
    var r1 = db.cityTbl.Where(c => c.State == "Oklahoma");// where will always result in a table (collection)
    r = JsonSerializer.Serialize(r1, opt);
    //Console.WriteLine(r);
    File.WriteAllText(filepath, r);
}

//all rows 

{
    //IEnumerable<City> r1 = db.cityTbl;//collection
    List<City> r1 = db.cityTbl.ToList();//collection

   for (int i = 0; i < r1.Count; i++)
    {
        Console.WriteLine(r1[i]);
    }

    r = JsonSerializer.Serialize(r1, opt);
   // Console.WriteLine(r);
    File.WriteAllText(filepath, r);

}

// add one row

//{
//    City newcity;// city, complex 
//    newcity = new City() { Name = "MIS3013",State="TX",population=26,lat=0,lon=0};
//    newcity.Id = 1000;

//    db.cityTbl.Add(newcity);//collection

//    db.SaveChanges();// save to the database file 

//    var r1 = db.cityTbl.Where(c => c.State == "Oklahoma");// where will always result in a table (collection)
//    r = JsonSerializer.Serialize(r1, opt);
//    //Console.WriteLine(r);
//    File.WriteAllText(filepath, r);
//}

{
    //var r1 = db.cityTbl.Where(c => c.State == "Texas").Where(c=>c.population>1000000);// where will always result in a table (collection)
    //City r1 = db.cityTbl.Where(c => c.State == "Texas" && c.population>1000000).FirstOrDefault();// where will always result in a table (collection)
    //var r1 = db.cityTbl.Where(c => c.State == "Texas").OrderByDescending(x=>x.population);// where will always result in a table (collection)
    //var r1 = db.cityTbl.OrderByDescending(x=>x.population).FirstOrDefault();// where will always result in a table (collection)
    //r1.population = 4000000;

    //db.SaveChanges();

    //db.cityTbl.Remove(r1);
    //db.SaveChanges();

    //var r1 = db.cityTbl.Min(x=>x.population);// single number 
    //var r1 = db.cityTbl.Average(x=>x.population);// single number 
    var r1 = db.cityTbl.ToList().MaxBy(x=>x.population);// single number 
    //min max
    // average is always a double 
    //minby
    r = JsonSerializer.Serialize(r1, opt);
    //Console.WriteLine(r);
    File.WriteAllText(filepath, r);
}