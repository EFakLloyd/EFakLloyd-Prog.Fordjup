
class Program{
  static void Main (string[] args){

Console.WriteLine("Skriv in ett registreringsnummer: ");
String regnr = Console.ReadLine();

if (ValideringAvRegnr(regnr)){
Console.WriteLine("Ja");
  }
else{
  Console.WriteLine("Nej");
  }
}


static bool ValideringAvRegnr(string regnr){
  if (regnr.Length !=6){
    return false;
  }
  string bokstav = regnr.Substring(0, 3);
  string siffra = regnr.Substring(3);

  

  if(char.IsLetter(bokstav[0])&&char.IsLetter(bokstav[1])&&char.IsLetter(bokstav[2])&& 
  char.IsDigit(siffra[0])&& char.IsDigit(siffra[1])&& char.IsDigit(siffra[2])){
    return true;

  }
if(char.IsLetter(bokstav[0])&&char.IsLetter(bokstav[1])&&char.IsLetter(bokstav[2])&& 
  char.IsDigit(siffra[0])&& char.IsDigit(siffra[1])&& char.IsLetter(bokstav[2])){
    return true;
  }
return false;
}}