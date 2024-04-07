String Frase;

Console.WriteLine("----Imitando a Dory----");

Console.Write("\nDigite uma Frase:" );
Frase = Console.ReadLine()!;

String FraseEmBaleis = Frase
.Replace("a", "aaa") 
.Replace("A", "AAA") 
.Replace("e", "eee") 
.Replace("E", "EEE") 
.Replace("i", "iii") 
.Replace("I", "III") 
.Replace("o", "ooo") 
.Replace("O", "OOO") 
.Replace("u", "uuu") 
.Replace("U", "UUU");

Console.WriteLine($"\nEm baleies:{FraseEmBaleis}");