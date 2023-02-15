// "Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее."); 
Console.WriteLine("Vvedite dva chisla a,b ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


int max;

if(a>b)  {
 max=a; 

Console.WriteLine( "chislo" + " "+ max); 
}
else

if(a<b)   { max=b;
   Console.WriteLine( "chislo "+ " " + max); 
}



