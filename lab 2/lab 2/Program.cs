using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
      Console.WriteLine("завдання 8!");
      String str= Console.ReadLine();
      int elemA = 0;
      int elemO = 0;
      int elemI = 0;
      int elemE = 0;
      for(int i = 0; i < str.Length; i++)
      {
        switch(str[i]){
          case 'a':
            elemA+=1;
            break;
          case 'o':
            elemO += 1;
            break;
          case 'i':
            elemI += 1;
            break;
          case 'e':
            elemE += 1;
            break;
        }
      }
      Console.WriteLine($"A:{elemA},O:{elemO},I:{elemI},E:{elemE}");
    }
  }
  }




/*1
 * Console.WriteLine("завдання 1!");
      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      for (int i = a; i <= b; i++)
        if (i % 3 == 0)
          count = count + 1;
        Console.WriteLine(count);
      Console.ReadKey();
 
 *2
     Console.WriteLine("завдання 2!");
     string str = "qwertyuiop";
      
      foreach (char c in str)
        Console.WriteLine(c);
      for (int i = 1; i < str.Length; i += 2)
      {
        
          Console.WriteLine(str[i]);
        
      }
      Console.ReadKey();

        
 
 
3
     Console.WriteLine("завдання 3!");
      string drink=Console.ReadLine();
      switch (drink){
        case "кава":
        case "Кава":
          Console.WriteLine("Кава коштує 55 грн.");
          break;
        case "чай":
        case "Чай":
          Console.WriteLine("Чай коштує 20 грн");
          break;
        case "Сік":
        case "сік":
          Console.WriteLine("Сік коштує 25 грн");
          break;
        case "вода":
        case "Вода":
          Console.WriteLine("вода коштує 10 грн");
          break;
      }
      Console.ReadKey();

4
      Console.WriteLine("завдання 4!");
      float a;
      float sum = 0;
      float count = 0;
      float avg = 0;

      do
      {
        a = Convert.ToInt32(Console.ReadLine());
        sum = sum + a;
        count++;
       
      }
      while (a > 0);
      avg = (sum - a) / (count - 1);
      Console.WriteLine(avg);
      Console.ReadKey();
5
      Console.WriteLine("завдання 5!");
      int a;
      a = Convert.ToInt32(Console.ReadLine());
      if (a % 4 == 0)
      {if((a % 100 != 0)||((a%100==0)&&(a%400==0)))
        Console.WriteLine("Високовосний рік");
      }
      else
      {
        Console.WriteLine("не високовосний рік");
      }




6

     Console.WriteLine("завдання 6!");
      string a;
      a = Console.ReadLine();
      int sum = 0;
      foreach(char p in a)
      {
        sum +=Convert.ToInt32(p.ToString());
      }
      Console.WriteLine(sum);
    }


7
      Console.WriteLine("завдання 7!");
      int a = Convert.ToInt32(Console.ReadLine());
      int b;
      int c;
      int d;
      for (int i = 0; i < a; i++)
      {
        b = (int)(a % 10);
        c = (int)(a / 10);
        d=(int)(c/10);
        if ((b % 2 == 0)||(c % 2 == 0)||(d%2==0))
           {
          Console.WriteLine("в числі " + a + " є парні цифри"); }
        else {
          Console.WriteLine("в числі " + a + " всі цифри непарні"); }
        Console.ReadKey();

9
      Console.WriteLine("завдання 9!");
      int a;
      Console.WriteLine("введіть номер місяця");
      a =Convert.ToInt32(Console.ReadLine());
      if (a==1 || a==3 ||a==5 || a==7 || a==8 || a==10 || a==12)
        Console.WriteLine("в "+a+" місяці 31 день");
      else if(a == 2)
        Console.WriteLine("в " + a + " місяці 28 днів");
      else if (a==4||a==6||a==9||a==11)
        Console.WriteLine("в " + a + " місяці 30 днів");
      else
        Console.WriteLine("помилка");
      Console.ReadKey();

 
 10
      Console.WriteLine("завдання 10!");
      int a;
      int length = 10;
      int[]array=new int[length];
      int sum =0;

      for (int i = 0; i<length; i++)
      {
        a = Convert.ToInt32(Console.ReadLine());
        array[i]=a;
        sum = array[0]+array[1]+array[2]+array[3]+array[4];
        if (a > 0)
        {
          Console.WriteLine(sum);
        }
        else
        {
          Console.WriteLine("kd_");
        }

      }

 
 
 
 
 */
