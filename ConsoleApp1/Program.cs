// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

while (true)
{
    string inpute = Console.ReadLine();
    if (inpute == "exit")
        break;
    int num = 0;
    
    if (int.TryParse(inpute, out num))
    {
        bool result = false;
        if (num % 2 != 0)
        {

            for (int i = 3; i < (num > 100 ? 100 : num - 1); i += 2)
            {

                if (num % i == 0)
                {
                    result = true;
                    break;
                }
            }
        }
        else
        {
            if (num != 2)
                result = true;
        }
    
        if (result)
            Console.WriteLine(num + "不是質數");
        else
            Console.WriteLine(num + "是質數");
    }
    else
    {
        Console.WriteLine("請輸入數字");
    }
}