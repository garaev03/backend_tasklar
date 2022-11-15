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
double mebleg = 0;

if (name == "Avtobus" || name=="avtobus")
{
    mebleg = 6;
    if (hour == 1)
    {
        Console.WriteLine("Ödeyeceyiniz mebleğ: " + mebleg);
    }
    else if (hour > 0)
    {
        mebleg = hour*mebleg +  (hour-1)*((mebleg * 21.5) / 100);
        Console.WriteLine("Ödeyeceyiniz mebleğ: "+mebleg);
    }
    else
    {
        Console.WriteLine("Siz heç bir mebleg ödemeyeceksiz!");
    }
}
else if(name=="Taksi" || name == "taksi")
{
    mebleg = 5;
    if (hour == 1)
    {
        Console.WriteLine("Ödeyeceyiniz mebleg: " + mebleg);
    }
    else if (hour > 0)
    {       
        mebleg = hour*mebleg+(hour-1)*((mebleg * 20) / 100);
        Console.WriteLine("Ödeyeceyiniz mebleg: " + mebleg);
    }
    else
    {
            Console.WriteLine("Siz heç bir mebleg ödemeyeceksiz!");
    }
}
else if (name == "Yuk masini" || name == "yuk masini" || name=="Yük maşını" || name=="yük maşını")
{
    mebleg = 6.5;
    if (hour == 1)
    {
        Console.WriteLine("Ödeyeceyiniz mebleg: " + mebleg);
    }
    else if (hour > 0)
    {
        mebleg = hour * mebleg + (hour - 1) * ((mebleg * 20) / 100);
        Console.WriteLine("Ödeyeceyiniz mebleg: " + mebleg);
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