using System;
// 1 

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isPrime = true;

for(int i = 2; i < number ;i++) // (i*i <= number) daha optimal olurmus https://programmercave.com/blog/2023/02/28/Optimized-Algorithm-for-Checking-Prime-Numbers-A-Comprehensive-Guide
{
    if(number % i ==0)
    {
        isPrime = false;
        break;
    }
}

if(isPrime)
    Console.WriteLine(number+" is prime.");
else
    Console.WriteLine(number+" is not prime.");

Console.WriteLine();
// 2

Console.WriteLine("Enter number: ");
number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number;

while(number%2==0)
{
    number/=2;
}

if(number == 1)
    Console.WriteLine(tempNumber+" is power of 2");
else
    Console.WriteLine(tempNumber+" is not power of 2");

Console.WriteLine();
// 3

Console.WriteLine("Enter number: ");
number = Convert.ToInt32(Console.ReadLine());
int counter = 0;

do
{
    counter++;
    number/=10;
}while(number != 0);

Console.WriteLine(counter);