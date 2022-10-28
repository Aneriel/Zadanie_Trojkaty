// See https://aka.ms/new-console-template for more information
string  wejscie = Console.ReadLine;
int[] bok = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
double obwodTrojkataDziel = (bok[0] + bok[1] + bok[2])/2;
double pole = Math.Round(Math.Sqrt(obwodTrojkataDziel * (obwodTrojkataDziel - bok[0])*(obwodTrojkataDziel - bok[1])*(obwodTrojkataDziel - bok[2])),2 );

if (bok[0]>=0 || bok[1]>=0 || bok[2] >= 0) { 
if (bok[0] > bok[1] + bok[2]|| bok[1] > bok[0] + bok[2] || bok[2] > bok[1] + bok[0])
{
    Console.Write("Błędne dane. Trójkąta nie można zbudować!");
}
else
{
    Console.WriteLine($"obwód = {bok[0] + bok[1] + bok[2]}");
    Console.WriteLine($"pole = {pole} ");
        if ((bok[0] * bok[0]) + (bok[1] * bok[1]) == (bok[2] * bok[2])||(bok[2] * bok[2]) + (bok[1] * bok[1]) == (bok[0] * bok[0])||(bok[0] * bok[0]) + (bok[2] * bok[2]) == (bok[1] * bok[1]))
            {
            Console.WriteLine("trójkąt jest prostokątny");
            }
        else if((bok[0] * bok[0]) + (bok[1] * bok[1]) < (bok[2] * bok[2])||(bok[2] * bok[2]) + (bok[1] * bok[1]) < (bok[0] * bok[0])||(bok[0] * bok[0]) + (bok[2] * bok[2]) < (bok[1] * bok[1]))
        {
            Console.WriteLine("Trójkąt jest rozwartokątny");
        }
        else
        {
            Console.WriteLine("Trójkąt jest ostrokątny");
        }

        if (bok[2] == bok[0] && bok[1] == bok[0])
       {
        Console.WriteLine("trójkąt równoboczny");
            }
  
}
}
else
{
    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
};
 