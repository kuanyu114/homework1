// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

while (true)
{
    string inpute = Console.ReadLine();
    if (inpute == "exit")
        break;
    int num = 0;
    int[] check = new int[] {2,3,5,7,11,13,17,19,23,29,
                             31,37,41,43,47,53,59,61,67,71,
                             73,79,83,89,97};
    if (int.TryParse(inpute, out num))
    {
        bool result = false;
        if (num % 2 != 0)
        {

            //for (int i = 3; i < (num > 100 ? 100 : num - 1); i += 2)
            //{

            //    if (num % i == 0)
            //    {
            //        result = true;
            //        break;
            //    }
            //}
            for (int i = 0; i < check.Length; i++)
            {
                if (num % check[i] == 0)
                {
                    if (num == check[i])
                    {
                        break;
                    }
                    result = true;
                    break;
                }
                else
                {
                    if (num / check[i] == check[i])
                    {
                        break;
                    }
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