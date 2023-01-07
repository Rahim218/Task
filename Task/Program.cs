
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
//        Console.WriteLine(mebleg * 1.7 + " " + "AZN");
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
//if ( a == "Beli")
//{
//    Console.WriteLine("Mudafie Nazirliyi :");
//    Console.WriteLine(budce * 0.2);
//    Console.WriteLine("Yuksek Texnologiyalar nazirliyi :");
//    Console.WriteLine(budce * 0.1);
//}
//else if ( a == "Yox")
//{
//    Console.WriteLine("ssssssss");
//}
//Console.WriteLine("Yerde qalan budce :");
//Console.WriteLine(budce - (budce * 0.2 + budce * 0.1));
#endregion









#region Kargo sifarisi
//Console.WriteLine("Trendyola xos gelmisiniz .. Marka ve mehsullarinizin sayini qeyd edin");
//string[] marka = { "Adidas", "Gucci", "Nike" };
//int toplam = 0;

//int[] price = { 200, 1000, 150 };
//for (int i = 0; i < 3; i++)
//{
//    string _marka = Console.ReadLine();

//    if (_marka == marka[i])
//    {
//        Console.WriteLine("Mehsulun sayini daxil edin");
//        int mehsulSayi = int.Parse(Console.ReadLine());
//        Console.WriteLine("Yekun qiymet :");
//        int yekun = price[i] * mehsulSayi;
//        Console.WriteLine($"{yekun} USD");
//        toplam += yekun;
//    }
//}
//Console.WriteLine($"Toplam xerclediyiniz mebleg {toplam} USD");


#endregion


#region Menfi elementlerin cemi ve sayi
////int n = 10;
////Random random = new Random();
////int[] numbers = new int[n];
////for (int i = 0; i < numbers.Length; i++)
////{
////    numbers[i] = random.Next(-50, 50);
////    Console.WriteLine(numbers[i]);
////}



//int toplam = 0;
//int count = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < 0)
//    {
//        toplam += numbers[i];
//        count++;
//    }
//}
//Console.WriteLine($"Menfi ededlerin cemi {toplam}");
//Console.WriteLine($"Menfi ededlerin sayi {count}");
#endregion

#region 5 e bolunen ve 7 e bolunmeyen reqemlerin cemi ve sayi
//int n = 10;
//Random random = new Random();
//int[] numbers = new int[n];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1, 50);
//    Console.WriteLine(numbers[i]);
//}

//int toplam = 0;
//int count = 0;
//for (int j = 0; j < numbers.Length; j++)
//{
//    if (numbers[j] % 5 ==0 && numbers[j] %7 !=0)
//    {
//        toplam += numbers[j];
//        count++;
//    }
//}
//Console.WriteLine($" 5-e bolunen ve 7 -ye bolunmeyen reqemlerin cemi {toplam}");
//Console.WriteLine($"5-e bolunen ve 7 -ye bolunmeyen reqemlerin eqemlerin sayi {count}");
#endregion

#region Musbet ve tek ededlerin sayi ve cemi
//Console.WriteLine("Elementlerin sayini daxil edin");
//int n = int.Parse(Console.ReadLine());
//int[] number = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.Write("Zehmet olmasa reqem daxl edin :  ");
//    int _number = int.Parse(Console.ReadLine());
//    number[i] = _number;
//}
//int sum = 0;
//int count = 0;
//for (int  j= 0; j < number.Length;j ++)
//{
//    if (number[j] > 0 && number[j]%2==1)
//    {
//        sum += number[j];
//        count++;
//    }
//}
//Console.WriteLine($"Musbet ve tek ededlerin cemi {sum}");
//Console.WriteLine($"Musbet ve tek ededlerin sayi {count}");

#endregion

#region Cut yerde duran cut reqemlerin cemi ve sayi
//Console.WriteLine("Ededlerin sayini daxil edin");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("_________________________");
//Random random = new Random();
//int[] numbers = new int[n];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1, 50);
//    Console.WriteLine(numbers[i]);
//}


//int sum = 0;
//int count = 0;
//for (int j = 0; j   < numbers.Length; j++)
//{
//    if (j % 2 == 1 && numbers[j]%2==0)
//    {
//        sum += numbers[j];
//        count++;
//    }
//}
//Console.WriteLine($" Cut yerde duran cut  reqemlerin cemi {sum}");
//Console.WriteLine($"Cut yerde duran cut reqemlerin  sayi {count}");
#endregion

#region Tek yerde duran tek reqemlerin cemi ve sayi
//Console.WriteLine("Ededlerin sayini daxil edin");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("_________________________");
//Random random = new Random();
//int[] numbers = new int[n];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1, 50);
//    Console.WriteLine(numbers[i]);
//}


//int sum = 0;
//int count = 0;
//for (int j = 0; j < numbers.Length; j+=2)
//{
//    if ( numbers[j] % 2 == 1)
//    {
//        sum += numbers[j];
//        count++;
//    }
//}
//Console.WriteLine($" Tek yerde duran tek  reqemlerin cemi {sum}");
//Console.WriteLine($"Tek yerde duran tek reqemlerin  sayi {count}");
#endregion


#region 7 e bolunende qaligi 1,2 ve ya 5 olan reqemlerin cemi ve sayi
//Console.WriteLine("Elementlerin sayini daxil edin");
//int n = int.Parse(Console.ReadLine());
//int[] number = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.Write("Zehmet olmasa reqem daxl edin :  ");
//    int _number = int.Parse(Console.ReadLine());
//    number[i] = _number;
//}
//int sum = 0;
//int count = 0;
//for (int j = 0; j < number.Length; j++)
//{
//    if (number[j] %7 == 1 || number[j] % 7 ==2 || number[j] % 7 ==5)
//    {
//        sum+=number[j];
//        count++;
//    }

//}
//Console.WriteLine($" 7 e bolunende qaligi 1,2 ve ya 5 olan reqemlerin cemi {sum}");
//Console.WriteLine($" 7 e bolunende qaligi 1,2 ve ya 5 olan reqemlerin sayi {count}");
#endregion


#region Iki qat artirilmis  tek olan ededlerin sayi
//Console.WriteLine("Elementlerin sayini daxil edin");
//int n = int.Parse(Console.ReadLine());
//int[] number = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.Write("Zehmet olmasa reqem daxl edin :  ");
//    int _number = int.Parse(Console.ReadLine());
//    number[i] = _number;
//}

//int count = 0;
//for (int j = 0; j < number.Length; j++)
//{
//    for (int i = 0; i < number.Length; i++)
//    {
//        if (number[i] == number[j] * 2 && number[j] % 2 == 1)
//        {
//            count++;
//        }
//    }
//}

//Console.WriteLine($"Iki qat artirilmis tek eded olan reqemlerin sayi {count}");

#endregion

#region Array icindeki en boyuk ve en kicik reqemin indeksi nomresini tapan alqoritma
//int n = 10;
//Random random = new Random();
//int[] numbers = new int[n];
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1, 100);
//    Console.WriteLine(numbers[i]);
//}

//int max = 0;
//int min = 0;
//for (int i = 1; i < numbers.Length; i++)
//{



//    if (numbers[i] > numbers[max])
//    {
//       max = i;
//    }
//    if (numbers[i]< numbers[min])
//    {
//        min = i;    
//    }
    
//}

//Console.WriteLine( $"En boyuk reqemin sirasi {max}");
//Console.WriteLine($"En kicik reqemin sirasi {min}");


#endregion

