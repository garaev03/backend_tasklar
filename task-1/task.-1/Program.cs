Console.WriteLine("Daxil ede bileceyiniz neqliyyatlar: ");
Console.WriteLine("1. Avtobus");
Console.WriteLine("2. Taksi");
Console.WriteLine("3. Yük maşını");
Console.WriteLine(" ");

Console.Write("Neqliyyatı qeyd edin: ");
string name = Console.ReadLine();
Console.Write("Saatı qeyd edin: ");
int hour=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
double mebleg = 0,evvelkiMebleg=0,sonrakiMebleg=0;

if (name == "Avtobus" || name=="avtobus")
{
    mebleg = 0;
    evvelkiMebleg = 0;
    sonrakiMebleg = 6;
    if (hour > 0)
    {
        while (hour > 0)
        {
            mebleg = evvelkiMebleg + sonrakiMebleg;
            sonrakiMebleg = (sonrakiMebleg + ((sonrakiMebleg * 21.5) / 100));
            evvelkiMebleg = mebleg;
            hour--;
        }
        Console.WriteLine("Ödeceyiniz mebleg: " + mebleg);
    }
    else
    {
        Console.WriteLine("Siz heç bir mebleg ödemeyeceksiz!");
    }
}
else if(name=="Taksi" || name == "taksi")
{
    mebleg = 0;
    evvelkiMebleg = 0;
    sonrakiMebleg = 5;
    if (hour > 0)
    {
        while (hour > 0)
        {
            mebleg = evvelkiMebleg + sonrakiMebleg;
            sonrakiMebleg = (sonrakiMebleg + ((sonrakiMebleg * 20) / 100));
            evvelkiMebleg = mebleg;
            hour--;
        }
        Console.WriteLine("Ödeceyiniz mebleg: "+mebleg);
    }
    else
    {
        Console.WriteLine("Siz heç bir mebleg ödemeyeceksiz!");
    }
}
else if (name == "Yuk masini" || name == "yuk masini")
{
    mebleg = 0;
    evvelkiMebleg = 0;
    sonrakiMebleg = 6.5;
    if (hour > 0)
    {
        while (hour > 0)
        {
            mebleg = evvelkiMebleg + sonrakiMebleg;
            sonrakiMebleg = (sonrakiMebleg + ((sonrakiMebleg * 25) / 100));
            evvelkiMebleg = mebleg;
            hour--;
        }
        Console.WriteLine("Ödeceyiniz mebleg: " + mebleg);
    }
    else
    {
        Console.WriteLine("Siz heç bir mebleg ödemeyeceksiz!");
    }
}
else
{
    Console.WriteLine("Zehmet olmasa düzgün neqliyyat qeyd edin!");
}