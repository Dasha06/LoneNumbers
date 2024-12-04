class FindOnesNumber 
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Введите числа через запятую для добавления в массив:");
        string input = Console.ReadLine();
        int[] numarr;
        if (!string.IsNullOrEmpty(input))
        {
            numarr = input.Split(',').Select(num => int.Parse(num.Trim())).ToArray();
        }
        else
        {
            numarr = new int[0];
        }

        int[] result = find(numarr);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
    
    public static int[] find(int[] nums)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (countMap.ContainsKey(num))
            {
                countMap[num]++;
            }
            else
            {
                countMap.Add(num, 1);
            }
        }
        
        List<int> result = new List<int>();
        foreach (KeyValuePair<int, int> pair in countMap)
        {
            if (pair.Value == 1)
            {
                result.Add(pair.Key);
            }
        }
        
        return result.ToArray();
    }
}