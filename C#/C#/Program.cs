using C;


EtreVivant jonathan = new EtreVivant();
EtreVivant joseph = new EtreVivant(new DateTime(1958, 01, 01));
EtreVivant jhonny = new EtreVivant();
Console.WriteLine($"jonathan : {jonathan.DateNaissance}");
Console.WriteLine($"joseph : {joseph.DateNaissance}");
Console.WriteLine($"jhonny : {jhonny.DateNaissance}");


int variable1 = 22;
int variable2 = variable1;
Console.WriteLine($"variavble1: {variable1}");
Console.WriteLine($"variavble2: {variable2}");
variable1++;
Console.WriteLine($"variavble1: {variable1}");
Console.WriteLine($"variavble1: {variable2}");