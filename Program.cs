using finalFantasy.src.Entities;

Knight Louis = new("Louis", "Guerreiro", 22);
Ninja Shigeru = new("Shigeru", "Ninja", 16);
BlackWizard Tilico = new("Tilico", "Black Wizard", 32);
WhiteWizard Luna = new("Luna", "White Wizard", 27);

Console.WriteLine(Louis);
Console.WriteLine(Shigeru);
Console.WriteLine(Luna);
Console.WriteLine(Tilico);
Console.WriteLine(Louis.Attack(64));
Console.WriteLine(Shigeru.Ninjutsu());
Console.WriteLine(Tilico.BlackHole(12));
Console.WriteLine(Luna.HighHeal());