// MIS 3033 002
// September 20, 2023
// Abigail Pidgeon 113515288

using a;
using System.Text.Json;

Console.WriteLine("City Database");

CityDB db;
db = new CityDB();// create the database connection

string r; // result string 
string filepath = "data.txt";

var opt = new JsonSerializerOptions();
opt.WriteIndented = true;

var r1 = db.cityTbl.Where(c => c.State == "Oklahoma");// where will always result in a table (collection)

r = JsonSerializer.Serialize(r1, opt);
Console.WriteLine(r);

File.WriteAllText(filepath, r);