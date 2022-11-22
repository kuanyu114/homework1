// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string inpute = Console.ReadLine();
int num = 0;
if (int.TryParse(inpute, out num))
{
    bool result = false;
    for (int i = 2; i < (num >100 ? 100: num-1); i++)
    {
       
        if (num % i == 0)
        {
            result = true;
            break;
        }
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