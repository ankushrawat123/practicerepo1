// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter any number to check whether you enter palindrome number or not");
int num = Convert.ToInt32(Console.ReadLine());

int rev = 0;
int a = num;

while(num>0)
{
    rev = rev * 10 + num % 10;
    num = num / 10;
}
if (a == rev)
{
  Console.WriteLine("{0} is a palindrome number", a);
}
else
{ Console.WriteLine("{0} is not a Palindrome number", a); 
}