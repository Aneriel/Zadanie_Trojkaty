Console.Write("Podaj pierwszy bok trójkąta:");
double bokPierwszy = double.Parse(Console.ReadLine());
Console.Write("Podaj drugi bok trójkąta:");
double bokDrugi = double.Parse(Console.ReadLine());
Console.Write("Podaj trzeci bok trójkąta:");
double bokTrzeci = double.Parse(Console.ReadLine());
double obwodTrojkataDziel = (bokPierwszy + bokDrugi + bokTrzeci)/2;
double pole = Math.Round(Math.Sqrt(obwodTrojkataDziel * (obwodTrojkataDziel - bokPierwszy)*(obwodTrojkataDziel - bokDrugi)*(obwodTrojkataDziel - bokTrzeci)),2 );


if (bokPierwszy > bokDrugi + bokTrzeci|| bokDrugi > bokPierwszy + bokTrzeci || bokTrzeci > bokDrugi + bokPierwszy)
{
    Console.Write("Błędne dane. Trójkąta nie można zbudować!");
}
else
{
    Console.WriteLine($"obwód = {bokPierwszy + bokDrugi + bokTrzeci}");
    Console.WriteLine($"pole ={pole} ");
    Console.WriteLine($"Test testu");

    if (bokTrzeci == bokPierwszy && bokDrugi == bokPierwszy)
    {
        Console.WriteLine("trójkąt równoboczny");
    }
} ;
