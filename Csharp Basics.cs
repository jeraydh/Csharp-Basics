/namespace
using System;
//application namespace
namespace CsharpBasics
{
class Program //C# class
{
//Main() method , entry point of the application
static void Main(string[] args)
{
//declaring constant of type byte
const byte sample1 = 0x3A;
//declaring constant of type byte
const byte sample2 = 58;
//declaring variable of type int
int heartRate = 85;
//declaring a variable of type double
double deposits = 135002796;
//declaring a constant float
float acceleration = 9.800F;
//declaring a variable float
float mass = 14.6F;
//declaring a variable double
double distance = 129.763001;
//declaring a variable bool
bool lost = true;
//declaring a variable bool
bool expensive = true;
//declaring a variable int
int choice = 2;
//declaring constant of type char
char integral ='\u222B';
//declaring constant String
const string greeting = "Hello";
//declaring a variable String
string name = "Karen";
//Comparing sample1 to sample2
if(sample1==sample2)
{
//comparing two samples
Console.WriteLine("The samples are equal.");
}
else
{
Console.WriteLine("The samples are not equal.");
}
//checking heartRate
if(heartRate>=40 && heartRate<=80)
{
//if hearRate is greater than or equal to 40 and
//less than or equal to 80 then
Console.WriteLine("Heart rate is normal.");
}
else
{
Console.WriteLine("Heart rate is not normal.");
}
//checking deposit
if (deposits >= 100000000)
{
//if deposit is greater than or equal to
Console.WriteLine("You are exceedingly wealthy.");
}
else
{
Console.WriteLine("Sorry you are so poor");
}
//declaring a variable
float force = mass * acceleration;
//display force
Console.WriteLine("force = "+force);
//displaying value of distance
Console.WriteLine(distance+ " is the distance");
//checking lost and expensive
if(lost==true && expensive==true)
{
//if both lost and expensive are true then
Console.WriteLine("I am really sorry! I will get the manager.");
}
else if(lost==true && expensive==false)
{
//if lost is true and expensive is false then
Console.WriteLine("Here is coupon for 10% off.");
}
//using switch case
switch (choice)
{
case 1: Console.WriteLine("You chose 1.");
break;
case 2: Console.WriteLine("You chose 2.");
break;
case 3: Console.WriteLine("You chose 3.");
break;

default:
Console.WriteLine("You made an unknown choice.");
break;
}
//display char constant
Console.WriteLine(integral+ " is an integral.");
//using for loop
for (int i= 5;i<=10; i++)
{
//display value of i
Console.WriteLine("i="+i);
}
//declaring int variable
int age = 0;
//using while loop
while (age<6)
{
//display value of age
Console.WriteLine("age="+age);
age = age + 1;//increment value of age
}
//display greeting
Console.WriteLine(greeting+" "+name);
}
}
}
