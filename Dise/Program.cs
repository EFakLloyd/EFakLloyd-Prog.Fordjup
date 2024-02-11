
string kasta="";
string dise1="";
string dise2="";
string dise3="";

for (int i = 0; i < 3; i++)
{
  

  Random random = new Random();
int dise = random.Next(1,6);

 switch (dise){
  case 1:
  kasta=" ett";
  break;
   case 2:
  kasta=" två";
  break;
  case 3:
  kasta=" tre";
  break;
   case 4:
  kasta=" fyr";
  break;
   case 5:
  kasta=" femm";
  break;
   case 6:
  kasta=" sex";
  break;
 }
 dise3=dise2;
 dise2=dise1;
 dise1=kasta;


}
if (dise1==dise2&&dise1==dise3){
  Console.WriteLine($"Tre{dise1}or");
}
else if(dise1==dise2){
  Console.WriteLine($"Två{dise1}or och en{dise3}a");

}
else if(dise1==dise3){
  Console.WriteLine($"Två{dise1}or och en{dise2}a");

}
else if(dise2==dise3){
  Console.WriteLine($"Två{dise2}or och en{dise1}a");

}
else {

Console.WriteLine($"En{dise1}a, en{dise2}a och en{dise3}a");
}
