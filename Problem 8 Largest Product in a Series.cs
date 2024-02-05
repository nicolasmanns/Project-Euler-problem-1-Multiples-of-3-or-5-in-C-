﻿
string number = "731671765313306249192251196744265747423553491949349698352031277450632623957831801698480186947885184385861560789112949495459501737958331952853208805511125469874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
int digitIndex =  0;
List<long> products = new List<long>(); // we will store our products here

char[] digits = number.ToCharArray(); 
long[] digitsINT = new long[999]; 

for (int i = 0; i < 999; i++) // conversion of string to chars then to int64
{
    digitsINT[i] = Convert.ToInt64(digits[i].ToString());
}

foreach (long digit in digitsINT) // for each digit, multiply it by the 12 following digits
{
  long product = digitsINT[digitIndex] * digitsINT[digitIndex + 1] * digitsINT[digitIndex + 2] * digitsINT[digitIndex + 3] * digitsINT[digitIndex + 4] * digitsINT[digitIndex + 5] * digitsINT[digitIndex + 6] * digitsINT[digitIndex + 7] * digitsINT[digitIndex + 8] * digitsINT[digitIndex + 9] * digitsINT[digitIndex + 10] * digitsINT[digitIndex + 11] * digitsINT[digitIndex + 12];
  products.Add(product); // store result in list
  digitIndex ++;

  if (digitIndex >= 987) // break at the end of the number
  {
    break;
  }
  
}

Console.WriteLine(products.Max()); // display highest product
Console.ReadKey();