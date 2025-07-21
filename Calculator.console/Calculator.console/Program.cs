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
}

//két számbekérése
Console.WriteLine("Kérem az első számot");
int elsoszam;
string elso = Console.ReadLine();
elsoszam=int.Parse(elso);

Console.WriteLine("Kérem a második számot");
int masodikszam;
string masodik = Console.ReadLine();
masodikszam = int.Parse(masodik);
    


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
 kérem az második számot amit tároljon egy változóba vizsgálja hogy számot adtam-e meg (int.parse, string.split)
 milyen művelet (osztás második szám nem lehet 0 (switch case string example)
 eredmény
  
 bool plus = szöveg == "+";
if (plus == true)
{
    Console.WriteLine("gyümölcs");
}
 
 
 
 
 */ 