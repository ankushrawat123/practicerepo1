// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter any number for factorial");
int num = Convert.ToInt32(Console.ReadLine());
int fact=1;
for (int i=1;i<=num;i++)
{
    fact=fact*i;
}
Console.WriteLine("Factorial of {0} is {1}",num,fact);
