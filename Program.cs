using Arv_part_2;


Console.WriteLine("vad vill du göra?");
Console.WriteLine("1.Rectangle");
Console.WriteLine("2.triangle");

string num=(Console.ReadLine());
Shape shape= null;
switch(num){

    case "1":
    Console.WriteLine("skriv höjden och bredden");
    shape= new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    
    
    break;

    case "2":
    Console.WriteLine("skriv höjden och bredden");
    shape= new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    
    
    break;
}
Console.WriteLine("Arean blir: "+ shape.Area());
Console.WriteLine("Omkrets blir: "+ shape.Cirumferance());

Console.WriteLine("Arean blir: "+ shape.Area());
Console.WriteLine("Omkrets blir: "+ shape.Cirumferance());
