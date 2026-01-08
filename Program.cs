Console.WriteLine("Hej och välkommna till Gitlektionen!");
Console.WriteLine("Vill du lära dig mer? (J/N)");
var svar = Console.ReadLine().ToLower();

if (svar == "j")
{
    Console.WriteLine("Nu har du lärt dig mer! :) ");
}
else if (svar == "n")
{
    Console.WriteLine("Nehe, strunt i det då!");
}