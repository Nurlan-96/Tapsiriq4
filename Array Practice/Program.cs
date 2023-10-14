#region Sum
//int[] numbers = { 1, 2, 3 };
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}

//Console.WriteLine(sum);

#endregion

#region 10-dan yuxari
//int[] n = { 7, 8, 9, 10, 11, 12, 13 };
//int count = 0;

//for (int i = 0; i < n.Length; i++)
//{
//    if (n[i] > 10)
//    { count++; }
//}
//Console.WriteLine(count);

//int[] numbers = { 10, 20, 30 };
//int sum = 0;
#endregion 

#region sum/n
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}

//Console.WriteLine(sum / numbers.Length);
#endregion

#region Aylar
string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

foreach (var item in months)
{
    if (item == "Mar" || item == "Apr" || item == "May")
    {
        Console.WriteLine("Yaz Aylari");
    }
}

#endregion