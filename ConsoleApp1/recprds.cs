using ConsoleApp1;
/*var p = new Post("dfwjwojfoi21",
    "post 1",
    "post 1 content",
    "Abed");
Console.WriteLine(p);
/*
var colors = new string[] { "red", "green", "yello", "black" };
for (var i = 0; i < colors.Length; i++)
{
    Console.WriteLine(colors[i]);
}
*/

List<string> colors = new List<string>();
Console.WriteLine(colors.Count);
colors.Add("red");
colors.Add("green");
colors.Add("yello");
colors.Add("black");
colors.Add("white");
colors[3] = "brown";
Console.WriteLine(colors.Count);

for (var i = 0; i < colors.Count; i++)
{
    Console.WriteLine(colors[i]);

}
Console.WriteLine("____________________");

colors.RemoveAt(3);
for (var i = 0; i < colors.Count; i++)
{
    Console.WriteLine(colors[i]);
}




