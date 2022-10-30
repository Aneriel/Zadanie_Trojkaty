// See https://aka.ms/new-console-template for more information
string  wejscie = Console.ReadLine();
double[] bok = Array.ConvertAll<string, double>(wejscie.Split("; "), double.Parse);
double obwod = bok[0] + bok[1] + bok[2];
double obwodTrojkataDziel = Math.Round((obwod/2),2);
string obwodS = String.Format("{0:0.00}",obwod);
double pole = Math.Round(Math.Sqrt(obwodTrojkataDziel * (obwodTrojkataDziel - bok[0])*(obwodTrojkataDziel - bok[1])*(obwodTrojkataDziel - bok[2])),2 );
string poleS = String.Format("{0:0.00}",pole);

if (bok[0] > 0 && bok[1] > 0 && bok[2] > 0) { 
    if (bok[0] > bok[1] + bok[2]|| bok[1] > bok[0] + bok[2] || bok[2] > bok[1] + bok[0])
    {
       Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
    }
    else
    {
        Console.WriteLine($"obwód = {obwodS}");
     Console.WriteLine($"pole = {poleS} ");
           if (Math.Pow(bok[0],2) + (bok[1] * bok[1]) == (bok[2] * bok[2])||(bok[2] * bok[2]) + (bok[1] * bok[1]) == (bok[0] * bok[0])||(bok[0] * bok[0]) + (bok[2] * bok[2]) == (bok[1] * bok[1]))
             {
              Console.WriteLine("trójkąt jest prostokątny");
             }
          else if((bok[0] * bok[0]) + (bok[1] * bok[1]) < (bok[2] * bok[2])||(bok[2] * bok[2]) + (bok[1] * bok[1]) < (bok[0] * bok[0])||(bok[0] * bok[0]) + (bok[2] * bok[2]) < (bok[1] * bok[1]))
             {
              Console.WriteLine("trójkąt jest rozwartokątny");
             }
          else
            {
             Console.WriteLine("trójkąt jest ostrokątny");
            }
          if (bok[2] == bok[0] && bok[1] == bok[0])
            {
             Console.WriteLine("trójkąt równoboczny");
            }
          else if (bok[0] == bok[1] || bok[2] == bok[0] || bok[2] == bok[1]){
             Console.WriteLine("trójkąt równoramienny");
            }   
}}
else
{
    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
}
 #if DEBUG
    Console.WriteLine("Press enter to close...");
    Console.ReadLine();
#endif