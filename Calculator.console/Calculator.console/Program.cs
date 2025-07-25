// See https://aka.ms/new-console-template for more information

Console.WriteLine("Calculator");
string szöveg = Console.ReadLine();  //addig blokkol míg nem ír be valaki valamit és enter

Console.WriteLine(szöveg);

string[] műveletek = new[] { "+", "-", "/", "*" };

bool írásjel = műveletek.Contains(szöveg); // for ciklussal végig megy a tömbön minden elemét összehasonlítaj a beadott adattal

if (írásjel == true)
{
    Console.WriteLine("helyes");
}
else
{
    Console.WriteLine("helytelen");
    return;
}

//két számbekérése
Console.WriteLine("Kérem az első számot");
float elsoszam;
string elso = Console.ReadLine();
elsoszam=int.Parse(elso);

Console.WriteLine("Kérem a második számot");
float masodikszam;
string masodik = Console.ReadLine();
masodikszam = int.Parse(masodik);

string[] megengedettkarakterek = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "," };

string[] split = masodik.Split(' ');



foreach (string szam in split)
{
    foreach (var megengedett in megengedettkarakterek)
    {
        if (szam == megengedett)
        {
            Console.WriteLine("szám");
        }
        else
        {
            Console.WriteLine("nem szám");
            return;
        }
    }
}
    


//milyen művelet,művelet elvégzése
switch (szöveg)
{
    case "+":
        Console.WriteLine($"Eredmeny: {elsoszam+masodikszam}"); 
        break;
    case "-":
        Console.WriteLine($"Eredmeny: {elsoszam-masodikszam}");
        break;
    case "*":
        Console.WriteLine($"Eredmeny: {elsoszam*masodikszam}");
        break;
    case "/":
        if (masodikszam == 0)
        {
            Console.WriteLine("Hiba: Nullával nem lehet osztani!");
        }
        else
        {
            Console.WriteLine($"Eredmeny: {elsoszam/masodikszam}"); 
        }
        break;
}





/*kérjük adja meg milyen művelet (+,-,/,*),
 ha nem műveletet ad meg  dobjon hibát (hiba) 
 kérem az első számot amit tároljon egy változóba (2 változó) vizsgálja hogy számot adtam-e meg (int.parse(string-et integer számmá alakítja), string.split, for/foreach)
 kérem az második számot amit tároljon egy változóba vizsgálja hogy számot adtam-e meg (int.parse, string.split) szamotadtam meg metódusba kell megírni 
 milyen művelet (osztás második szám nem lehet 0 (switch case string example)
 eredmény
  
 bool plus = szöveg == "+";
if (plus == true)
{
    Console.WriteLine("gyümölcs");
}
 
 
 
 
 */ 