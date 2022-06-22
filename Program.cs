String[] arr = { "hello", "27", "word", ":-)", "ref", "65f" };
string Print(string[] arr)
{
    string res = string.Empty;
    res = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (Convert.ToString(arr[i]).Length <= 3)
        {
            res += $"\"{arr[i]}\"";
            if (i < arr.Length - 1)
                res += ", ";
        }
    }
    res += "]";
    return res;
}
Console.WriteLine(Print(arr));