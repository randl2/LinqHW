namespace MyApp;

class Program
{
    static void Main()
    {
        //Завдання 1

        string allNums = string.Join(", ", Enumerable.Range(10, 41));

        Console.WriteLine("Завдання 1: " + allNums);

        //Завдання 2

        string allNumsThree = string.Join(", ", Enumerable.Range(10, 41).Where(x => x % 3 == 0));

        Console.WriteLine("Завдання 2: " + allNumsThree);

        //Завдання 3

        string linqTenTimesText1 = string.Join(", ", Enumerable.Repeat("Linq", 10));

        Console.WriteLine("Завдання 3: " + linqTenTimesText1);

        //Завдання 4

        Console.WriteLine("Завдання 4:");

        List<string> wordsWithA = "aaa;abb;ccc;dap"
                                .Split(';')
                                .Where(x => x.Contains("a"))
                                .ToList();
        foreach(string word in wordsWithA)
        {
            Console.WriteLine(word);
        }

        //Завдання 5

        Console.WriteLine("Завдання 5:");

        string amountOfA = string.Join(", ", "aaa;abb;ccc;dap"
                                .Split(';')
                                .ToList()
                                .Where(x => x.Contains("a"))
                                .Select(x => x.Count(x => x == 'a')));
        Console.WriteLine(amountOfA);

        //Завдання 6

        bool containsABB = "aaa;xabbx;abb;ccc;dap"
                                .Split(';')
                                .Any(x => x == "abb");
        Console.WriteLine("Завдання 6: " + containsABB);

        //Завдання 7

        string longestWord = "aaa;xabbx;abb;ccc;dap"
                                .Split(';')
                                .Select(word => new { Word = word, Length = word.Length })
                                .OrderByDescending(x => x.Length)
                                .FirstOrDefault()?
                                .Word;
        Console.WriteLine("Завдання 7: " + longestWord);

        //Завдання 8

        double averageLength = "aaa;xabbx;abb;ccc;dap"
                               .Split(';')
                               .ToList()
                               .Select(x => x.Length)
                               .Average();
        Console.WriteLine("Завдання 8: " + averageLength);

        //Завдання 9

        string shortestWord = new string("aaa;xabbx;abb;ccc;dap;zh"
                                .Split(';')
                                .Reverse()
                                .Select(word => new {Word = word, Length = word.Length})
                                .OrderBy(x => x.Length)
                                .FirstOrDefault()?
                                .Word
                                .ToCharArray()
                                .Reverse()
                                .ToArray());

        Console.WriteLine("Завдання 9: " + shortestWord);

        //Завдання 10

        bool firstBB = "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh"
                                .Split(';')
                                .Any(x => x.StartsWith("aa") && x.EndsWith("bb"));

        Console.WriteLine("Завдання 10: " + firstBB);

        //Завдання 11

        string lastBB1 = "baaa;aabb;aaa;xabbx;abb;ccc;dap;zh"
                                .Split(";")
                                .Where(x => x.EndsWith("bb"))
                                .Reverse()
                                .FirstOrDefault();

        Console.WriteLine("Завдання 11: " + lastBB1);

    }
}