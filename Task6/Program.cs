Console.WriteLine("Введи число и узнай является ли оно четным");
int num; 
    Console.Write("Введите число : ");
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.Write("Введенное число является четным");
        Console.Read();
    }        
        else
        { 
            Console.Write("Введенное число нечетное");
            Console.Read();
        }    