
#region Mezenne hesablama
//Console.WriteLine("Mebleg (AZN) daxil edin :");
//int mebleg = int.Parse(Console.ReadLine());
//Console.WriteLine("Secmek istediyiniz valyutani qeyd edin ...");
//string[] valyuta = { "USD", "EUR", "RUB" };
//for (int i = 0; i < valyuta.Length; i++)
//{
//    Console.WriteLine(valyuta[i]);
//}


//Console.WriteLine("----------------------------");
//ineligible:
//string secim = Console.ReadLine();
//for (int i = 0; i < valyuta.Length; i++)
//{
//    if (secim == valyuta[0])
//    {
//        Console.WriteLine(mebleg * 1.7 +" " +"AZN");
//        break;
//    }
//    else if (secim == valyuta[1])
//    {
//        Console.WriteLine(mebleg * 1.7887 + " " + "AZN");
//        break;
//    }
//    else if (secim == valyuta[2])
//    {
//        Console.WriteLine(mebleg * 0.0236 + " " + "AZN");
//        break; 

//    }
//}
//goto ineligible;
#endregion



#region Olke budcesi hesablama
//Console.WriteLine("Azerbaycan dovletinin illik ortalama budcesi : ");
//long budce = 20000000000;
//Console.WriteLine(budce);
//Console.WriteLine("Budceden ayrilmis vesaitleri oyrenmek isdiyirsinizse 'Beli' deyin");
//string a = Console.ReadLine();  
//    if (a == "Beli")
//{
//    Console.WriteLine("Mudafie Nazirliyi :");
//    Console.WriteLine(budce * 0.2);
//    Console.WriteLine("Yuksek Texnologiyalar nazirliyi :");
//    Console.WriteLine(budce * 0.1);
//}
//Console.WriteLine("Yerde qalan budce :");
//Console.WriteLine(budce - (budce*0.2 + budce*0.1));
#endregion









#region Kargo sifarisi
Console.WriteLine("Trendyola xos gelmisiniz .. Marka ve mehsullarinizin sayini qeyd edin");
string[] marka = { "Adidas", "Gucci", "Nike" };
int toplam = 0;

int[] price = { 200, 1000, 150 };
for (int i = 0; i < 3; i++)
{
    string _marka = Console.ReadLine();

    if (_marka == marka[i])
    {
        Console.WriteLine("Mehsulun sayini daxil edin");
        int mehsulSayi = int.Parse(Console.ReadLine());
        Console.WriteLine("Yekun qiymet :");
        int yekun = price[i] * mehsulSayi;
        Console.WriteLine($"{yekun} USD");
        toplam += yekun;
    }
}
Console.WriteLine($"Toplam xerclediyiniz mebleg {toplam} USD");


#endregion
