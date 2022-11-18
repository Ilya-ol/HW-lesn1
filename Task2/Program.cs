Console.WriteLine("Введи 2 числа и узнай какое из них больше, а какое меньше");
{
 
        int a, b;
 
        Console.WriteLine("Введите два числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} - наибольшее число, {1} - наименьшее число", a, b);
 
        }
 
        else
 
        {
 
             Console.WriteLine("{0} - наибольшее число, {1} - наименьшее число", b, a);
 
        }
 
        Console.ReadLine();
 
    }
   
