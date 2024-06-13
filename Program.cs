using System;


Console.Write("Bo`limni tanlang: ");
string inputSon = Console.ReadLine();

switch (inputSon)
{
   
    case "1" :
    { 
    int x = 3;
    int y = 6;
    int qoshish = x + y;
         Console.WriteLine("Arifmetigi= " + qoshish);
    break;
    }
    case "2":
    {
        int z =6;
        int f = 2;
        int kopaytirish = z * f;
            Console.WriteLine("Geometrigi= " + kopaytirish);
    break;
     }
    default:
    Console.WriteLine("Siz notog`ri tanladingiz");
    break;
}



// using System;
// Console.Write("Hafta kunini tanlang: ");
// string inputKun = Console.ReadLine();

// switch(inputKun)
// {
//     case "1":
//     Console.WriteLine("Dushanba");
//     break;

//     case "2":
//     Console.WriteLine("Seshanba");
//     break;
    
//     case "3":
//     Console.WriteLine("Chorshanba");
//     break;

//     case "4":
//     Console.WriteLine("Payshanba");
//     break;
    
//     case "5":
//     Console.WriteLine("Juma");
//     break;

//     case "6":
//     Console.WriteLine("Shanba");
//     break;
    
//     case "7":
//     Console.WriteLine("Yakshanba");
//     break;
    
//     default:
//     Console.WriteLine("Unday kun yo`q");
//     break;
// }