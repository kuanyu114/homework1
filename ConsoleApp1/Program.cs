// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region work1


//while (true)
//{
//    string inpute = Console.ReadLine();
//    if (inpute == "exit")
//        break;
//    int num = 0;
//    int[] check = new int[] {2,3,5,7,11,13,17,19,23,29,
//                             31,37,41,43,47,53,59,61,67,71,
//                             73,79,83,89,97};
//    if (int.TryParse(inpute, out num))
//    {
//        bool result = false;
//        if (num % 2 != 0)
//        {

//            //for (int i = 3; i < (num > 100 ? 100 : num - 1); i += 2)
//            //{

//            //    if (num % i == 0)
//            //    {
//            //        result = true;
//            //        break;
//            //    }
//            //}
//            for (int i = 0; i < check.Length; i++)
//            {
//                if (num % check[i] == 0)
//                {
//                    if (num == check[i])
//                    {
//                        break;
//                    }
//                    result = true;
//                    break;
//                }
//                else
//                {
//                    if (num / check[i] == check[i])
//                    {
//                        break;
//                    }
//                }
//            }
//        }
//        else
//        {
//            if (num != 2)
//                result = true;
//        }

//        if (result)
//            Console.WriteLine(num + "不是質數");
//        else
//            Console.WriteLine(num + "是質數");
//    }
//    else
//    {
//        Console.WriteLine("請輸入數字");
//    }


//}

#endregion

int[] list = new int[] { 1, 2, 4, 7, 0, 0, 7, 5 };
int[] list1 = new int[] { 1, 0, 2, 4, 0, 5, 7 };
int[] list2 = new int[] { 1, 7, 2, 0, 4, 5, 0 };
int[] list3 = new int[] { 1, 7, 2, 7, 4, 5, 0 };

bool result = new newFunction().checkArry(list);
Console.WriteLine("result1" + result);
result = new newFunction().checkArry(list1);
Console.WriteLine("result2" + result);
result = new newFunction().checkArry(list2);
Console.WriteLine("result3" + result);
result = new newFunction().checkArry(list3);
Console.WriteLine("result4" + result);

public class newFunction
{
    public bool checkArry(int[] ints)
    {

        bool result = false;
        int count = 0;
        var zeroCount = ints.Count(n => n == 0);
        var sevenCount = ints.Count(n => n == 7);
        if (zeroCount >= 2 && sevenCount >= 1)
        {
            result = true;
        }
        return result;
    }
}