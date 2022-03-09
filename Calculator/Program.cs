// See https://aka.ms/new-console-template for more information

string functionality;

start:
Console.WriteLine("Please enter your choice : \n A - Add \n S - Sub \n M - Mul \n D - Div)");

functionality = Convert.ToString(Console.ReadLine());

if (functionality == "A" || functionality == "S" || functionality == "M" || functionality == "D")
{
    
    try
    {
        float no1, no2, add, sub, mul, div;
        Console.WriteLine("\nPlease enter first number :");

        no1 = (float)Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("\nPlease enter second number :");

        no2 = (float)Convert.ToDecimal(Console.ReadLine());

        if (functionality == "D" && no2 == 0)
        {
            Console.WriteLine("\nSecond number should not be zero :\n");
            goto start;
        }

    calc(no1, no2, out add, out sub, out mul, out div);
        if(functionality == "A")
        {
            Console.WriteLine("\n\nThe result of calculation is: {0}+{1}={2}", no1, no2, add);
        }
        if (functionality == "S")
        {
            Console.WriteLine("\n\nThe result of calculation is: {0}-{1}={2}", no1, no2, sub);
        }
        if (functionality == "M")
        {
            Console.WriteLine("\n\nThe result of calculation is: {0}*{1}={2}", no1, no2, mul);
        }
        if (functionality == "D")
        {
            Console.WriteLine("\n\nThe result of calculation is: {0}/{1}={2}", no1, no2, div);
        }   
    
    }
    catch
    {
        Console.WriteLine("\nPlease enter valid number\n");
        goto start;
    }
}
else
{
    Console.WriteLine("\nPlease enter correct choice\n");
    goto start;
}

static void calc(float no1, float no2, out float add, out float sub, out float mul, out float div)
{
    add = no1 + no2;
    sub = no1 - no2;
    mul = no1 * no2;
    if(no2 !=0)
    {
        div = no1 / no2;
    }
    else
    {
        div = 0;
    }

}






