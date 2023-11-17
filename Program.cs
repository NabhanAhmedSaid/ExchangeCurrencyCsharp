// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Excahne Currencies");
Console.WriteLine("Enter the amount in Rial Omani");
double omr = double.Parse(Console.ReadLine());
Console.Write("Okay, You have ");
Console.Write(omr);
Console.WriteLine(" OR");
Console.WriteLine("Press\n 1. convert to Indian Ruppe\n 2. convert United States Dollar");
int choose = int.Parse(Console.ReadLine());

switch(choose)
{
    case 1 :
    double inr = omr * 216.26;
Console.Write(inr);
Console.WriteLine(" Indian Ruppe");
  break;
  case 2:
  double usd = omr * 2.60;
  Console.Write(usd);
Console.WriteLine(" usd");
break;
  default:
  Console.WriteLine("Error");
  break;


}


