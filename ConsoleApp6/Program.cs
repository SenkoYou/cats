//сериализация десериализация

//сохраненние объектов в постоянную память
//вывод из постоянно памяти в оперативку

using ConsoleApp6;
using System.IO;
using System.Xml.Linq;

Cats Cat1 = new Cats();
Cat1.name = "Debil";
Cat1.type = "Cat";
Cat1.year = "18";


Cats Cat2 = new Cats();
Cat2.name = "Idiot";
Cat2.type = "Cat";
Cat2.year = "17";

Cats Cat3 = new Cats();
Cat3.name = "Durak";
Cat3.type = "Cat";
Cat3.year = "16";


Cats[] cats = new Cats[3];
cats[0] = Cat1;
cats[1] = Cat2;
cats[2] = Cat3;

Controller controller = new Controller();

controller.Save(cats);
var t = controller.Load("cats.json");

foreach (var item in t)
{
    Console.WriteLine(item.name + " " + item.type + " " + item.year);
}


























//using ConsoleApp6;
//using System.Text.Json;

//Sudent stud = new Sudent();
//stud.Group = "IS-22-07";
//stud.Name = "Student";
//stud.NumTelephone = "89270262725";

//var json = JsonSerializer.Serialize<Sudent>(stud);
//Console.WriteLine(json);

//File.WriteAllText("file.json", json);

//using ConsoleApp6;
//using System.Text.Json;

//var json =  File.ReadAllText("file.json"); //файла может не быть

//Sudent stud = JsonSerializer.Deserialize<Sudent>(json); //может произойти на ошибка при сериализации и десеарилазации

//Console.WriteLine($"{stud.Name}, {stud.Group}");


