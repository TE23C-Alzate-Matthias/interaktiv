string direction;
string mannen; 

// Console.WriteLine("Användarnamn: ");
// string name = Console.ReadLine();
// f (name = "matthias") {
//    Console.WriteLine("Välkommen");
// }
// else {
//    Console.WriteLine("FU");
// }

Console.WriteLine("Framför dig är det 2 dörrar. Höger eller Vänster?");
direction = Console.ReadLine();

if (direction.Equals("vänster", StringComparison.OrdinalIgnoreCase)) {
    Console.Clear();
    Console.WriteLine("Du öppnar den vänsta dörren och en bomb är framför dig och exploderar. Du dör. Game over! 1/5");
    Console.ReadLine();
}

else if (direction.Equals("höger", StringComparison.OrdinalIgnoreCase)) {
    Console.Clear();
    Console.WriteLine("Du öppnar den högra dörren. När du går igenom dörren och kollar backom dig så ser du inte dörren längre, isället ser du en man som är 50 meter bakom dig som går mot dig. Du har en känsla att han kommer ge dig något. Springer du eller Stannar du");
    mannen = Console.ReadLine();

    if (mannen.Equals("spring", StringComparison.OrdinalIgnoreCase)) {
        Console.Clear();
        Console.WriteLine("Du springer iväg från mannen så snabbt som möjligt men du snubblar och landar med huvudet först mot en sten. Du dör. Game over! 3/5");
        Console.ReadLine();
    }

    else if (mannen.Equals("stanna", StringComparison.OrdinalIgnoreCase)) {
        Console.Clear();
        Console.WriteLine("Din nyfikenhet tar över och du stannar och väntar på mannen. När han är framför dig skappar han");
        Console.ReadLine();
    }

    else {
        Console.Clear();
        Console.WriteLine("Du stannar upp i rädsla och får en hjärtattack och dör. Game over! 5/5");
        Console.ReadLine(); 
    }

}
else {
    Console.Clear();
    Console.WriteLine("Du gör ingenting och ett flygplan krashar och träffar dig, du dör direkt. Game over! 2/5");
    Console.ReadLine();
}


