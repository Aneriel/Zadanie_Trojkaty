string bokiStr = Console.ReadLine();
string[] bokiArr =bokiStr.Split(';',' ');
double boki = double.Parse(bokiStr);
Console.Write("Podaj pierwszy bok trójkąta:");
double bokPierwszy = double.Parse(Console.ReadLine());
Console.Write("Podaj drugi bok trójkąta:");
double bokDrugi = double.Parse(Console.ReadLine());
Console.Write("Podaj trzeci bok trójkąta:");
double bokTrzeci = double.Parse(Console.ReadLine());
double obwodTrojkataDziel = (bokPierwszy + bokDrugi + bokTrzeci)/2;
double pole = Math.Round(Math.Sqrt(obwodTrojkataDziel * (obwodTrojkataDziel - bokPierwszy)*(obwodTrojkataDziel - bokDrugi)*(obwodTrojkataDziel - bokTrzeci)),2 );

if (bokPierwszy>=0 || bokDrugi>=0 || bokTrzeci >= 0) { 
if (bokPierwszy > bokDrugi + bokTrzeci|| bokDrugi > bokPierwszy + bokTrzeci || bokTrzeci > bokDrugi + bokPierwszy)
{
    Console.Write("Błędne dane. Trójkąta nie można zbudować!");
}
else
{
    Console.WriteLine($"obwód = {bokPierwszy + bokDrugi + bokTrzeci}");
    Console.WriteLine($"pole = {pole} ");
        if ((bokPierwszy * bokPierwszy) + (bokDrugi * bokDrugi) == (bokTrzeci * bokTrzeci)||(bokTrzeci * bokTrzeci) + (bokDrugi * bokDrugi) == (bokPierwszy * bokPierwszy)||(bokPierwszy * bokPierwszy) + (bokTrzeci * bokTrzeci) == (bokDrugi * bokDrugi))
            {
            Console.WriteLine("trójkąt jest prostokątny");
            }
        else if((bokPierwszy * bokPierwszy) + (bokDrugi * bokDrugi) < (bokTrzeci * bokTrzeci)||(bokTrzeci * bokTrzeci) + (bokDrugi * bokDrugi) < (bokPierwszy * bokPierwszy)||(bokPierwszy * bokPierwszy) + (bokTrzeci * bokTrzeci) < (bokDrugi * bokDrugi))
        {
            Console.WriteLine("Trójkąt jest rozwartokątny");
        }
        else
        {
            Console.WriteLine("Trójkąt jest ostrokątny");
        }

        if (bokTrzeci == bokPierwszy && bokDrugi == bokPierwszy)
       {
        Console.WriteLine("trójkąt równoboczny");
            }
  
}
}
else
{
    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
};
 