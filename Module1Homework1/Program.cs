////1.Verilmiş iki ədədin cəmini hesablayan proqram yazın.

//Console.Write("Birinci ededi daxil edin: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Ikinci ededi daxil edin: ");
//int b = int.Parse(Console.ReadLine());
//int sum = a + b;
//Console.WriteLine("Iki ededin cemi: " + sum);

////2.Verilmiş ədədin cüt və ya tək olduğunu təyin edən proqram yazın.

//Console.Write("Bir eded daxil edin: ");
//int a = int.Parse(Console.ReadLine()); // Daxil edilən ədədin tam ədəd olduğunu qəbul edirik
//if (a % 2 == 0)
//{
//    Console.WriteLine("Eded cütdür!");
//}
//else
//{
//    Console.Write("Eded tekdir!");
//}

////3. Verilmiş bir ədədin müsbət, mənfi və ya sıfır olub-olmadığını təyin edən proqram yazın.

//Console.Write("Bir eded daxil edin: ");
//int a = int.Parse(Console.ReadLine());
//if (a > 0)
//{
//    Console.WriteLine("Eded müsbetdir!");
//}
//else if (a < 0)
//{
//    Console.Write("Eded menfidir!");
//}
//else
//{
//    Console.WriteLine("Eded sıfıra beraberdir!");
//}

////4. İstifadəçinin yaşına əsasən, onu bir kateqoriyaya aid edin: 0 - 12: Uşaq, 13-19: Yeniyetmə, 20 və yuxarı: Böyük.

//Console.Write("Yaşınızı daxil edin: ");
//int age = int.Parse(Console.ReadLine());

//if (age >= 0 && age <= 12)
//{
//    Console.WriteLine("Uşaq");
//}
//else if (age >= 13 && age <= 19)
//{
//    Console.WriteLine("Yeniyetme");
//}
//else if (age >= 20 && age <= 100)
//{
//    Console.WriteLine("Böyük");
//}
//else
//{
//    Console.WriteLine("Yanlış yaş");
//}

////5.İki ədəddən hansının daha böyük olduğunu müəyyən edən proqram yazın.

//Console.Write("Birinci ededi daxil edin: ");
//int a = int.Parse(Console.ReadLine());

//Console.Write("İkinci ededi daxil edin: ");
//int b = int.Parse(Console.ReadLine());

//if (a > b)
//{
//    Console.Write("Birinci eded daha böyükdür.");
//}
//else if (a < b)
//{
//    Console.Write("Ikinci eded daha böyükdür.");
//}
//else
//{
//    Console.WriteLine("Her iki eded beraberdir.");
//}

////6.İstifadəçidən 1-dən 7-yə qədər bir rəqəm daxil etməsini istəyin və ona uyğun həftənin gününü çap edin.Məsələn:1 → Bazar ertəsi və s.

//Console.Write("1-den 7-ye qeder bir reqem daxil edin: ");
//int weekNumber = int.Parse(Console.ReadLine());

//switch (weekNumber)
//{
//    case 1:
//        Console.WriteLine("Bazar ertəsi");
//        break;
//    case 2:
//        Console.WriteLine("Çərşənbə axşamı");
//        break;
//    case 3:
//        Console.WriteLine("Çərşənbə");
//        break;
//    case 4:
//        Console.WriteLine("Cümə axşamı");
//        break;
//    case 5:
//        Console.WriteLine("Cümə");
//        break;
//    case 6:
//        Console.WriteLine("Şənbə");
//        break;
//    case 7:
//        Console.WriteLine("Bazar");
//        break;
//    default:
//        Console.WriteLine("Zehmet olmasa, 1-den 7-ye qeder bir reqem daxil edin.");
//        break;
//}

////7.İlin təkcə 365 gündən yox,həm də sıçrayış ili (leap year) olub-olmadığını yoxlayın.İl 4-ə tam bölünməlidir,amma 100-ə bölünməməlidir və ya 400-ə tam bölünməlidir. 

//Console.Write("İli daxil edin: ");
//int year = int.Parse(Console.ReadLine());

//if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
//{
//    Console.WriteLine($"{year} sıçrayış ilidir.(366 gün)");
//}
//else
//{
//    Console.WriteLine($"{year} sıçrayış ili deyil.(365 gün)");
//}

////8.İstifadəçidən parol istəyin.Əgər parol düzgünsə,"Giriş uğurludur",əks halda "Yanlış parol" yazdırın.

//string correctPassword = "Pass12345@";
//Console.Write("Parolu daxil edin: ");
//string enteredPassword = Console.ReadLine();

//if (enteredPassword == correctPassword)
//{
//    Console.WriteLine("Giriş uğurludur");
//}
//else
//{
//    Console.WriteLine("Yanlış parol");
//}



