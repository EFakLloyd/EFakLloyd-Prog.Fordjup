using System;

//string reverse
namespace Dagbok2
{
class Program
{
  static void CalculateProduct(){
        System.Console.WriteLine("Skriv in ett heltal: ");
    int tal1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Skriv in ett heltal: ");
    int tal2 = Convert.ToInt32(Console.ReadLine());
  
    int summa = tal1+tal2;
   
    System.Console.WriteLine($"{tal1} + {tal2} = {summa}");
  }

  static void PrintFullName(){
     System.Console.WriteLine("Skriv ditt förnamn: ");
    string fNamn = Console.ReadLine();
    System.Console.WriteLine("Skriv ditt efternamn: ");
    string eNamn = Console.ReadLine();
    string fullName = fNamn + " " + eNamn;
    System.Console.WriteLine(fullName); 
  }

  static void CalculateRoot(){
    System.Console.WriteLine("Skriv in ett heltal: ");
    int tal = Convert.ToInt32(Console.ReadLine());

    double root = Math.Sqrt(tal);
    System.Console.WriteLine(root);
  }
  public static void Main(string[] args){

  // CalculateProduct();
  // PrintFullName();
  // CalculateRoot();
List<DiaryEntry> diaryEntries = new List<DiaryEntry>();
  
  while (true)
        {
            Console.WriteLine("1. Läs dagboksinlägg");
            Console.WriteLine("2. Skapa nytt dagboksinlägg");
            Console.WriteLine("3. Avsluta");

            Console.Write("Välj ett alternativ: ");
            int val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 1:
                    ReadEntry(diaryEntries);
                    break;
                case 2:
                    CreateEntry(diaryEntries);
                    break;
                case 3:
                    Console.WriteLine("Avslutar programmet...");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
  }
public static void ReadEntry(List<DiaryEntry> diaryEntries){


   if (diaryEntries.Count == 0)
            {
                Console.WriteLine("Det finns inga dagboksinlägg.");
                return;
            }

            Console.WriteLine("Vilket dagboksinlägg vill du läsa: ");
            int nummer = Convert.ToInt32(Console.ReadLine());

            if (nummer >= 1 && nummer <= diaryEntries.Count)
            {
                Console.WriteLine($"{diaryEntries[nummer - 1].Datum}: \nRubrik: {diaryEntries[nummer - 1].Rubrik}\nInnehåll:{diaryEntries[nummer - 1].Innehall}");

            }
            else
            {
                Console.WriteLine("Ogiltigt inläggsnummer.");
            }

}
public static void CreateEntry(List<DiaryEntry> diaryEntries){

var diaryEntry = new DiaryEntry();
            diaryEntry.Datum = DateTime.Now;

            Console.WriteLine("Skriv en rubrik: ");
            diaryEntry.Rubrik = Console.ReadLine();

            Console.WriteLine("Skriv innehåll: ");
            diaryEntry.Innehall = Console.ReadLine();

            diaryEntries.Add(diaryEntry);
}
}



public class DiaryEntry{

  public DateTime Datum {get; set;}
    public string Rubrik  {get; set;}
  public string Innehall  {get; set;}

   
}
}