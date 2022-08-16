

void ThreeSymbol(string[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        string str = arr[i];
        if(str.Length <= 3) Console.WriteLine(str);
    }
}


string[] array = {"hello", "2", "world", ":-)"};
// string[] array = {"1234", "1567", "-2", "computer science"};
// string[] array = {"Russia", "Denmark", "Kazan"};
ThreeSymbol(array);
