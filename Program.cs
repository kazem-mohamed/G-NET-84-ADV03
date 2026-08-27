public class Program
{
    public static void Main(string[] args)
    {
        #region Question 1
        List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };

        Console.WriteLine($"Grades: {string.Join(", ", grades)}");
        Console.WriteLine($"Count: {grades.Count}");
        Console.WriteLine($"First: {grades[0]}");
        Console.WriteLine($"Last: {grades[^1]}");

        grades.Sort();
        Console.WriteLine($"Sorted Grades: {string.Join(", ", grades)}");

        int firstAbove90 = grades.Find(g => g > 90);
        Console.WriteLine($"First grade above 90: {firstAbove90}");

        List<int> failingGrades = grades.FindAll(g => g < 75);
        Console.WriteLine($"Failing grades (below 75): {string.Join(", ", failingGrades)}");

        grades.RemoveAll(g => g < 75);
        Console.WriteLine($"Grades after removing failing grades: {string.Join(", ", grades)}");

        bool hasPerfectScore = grades.Contains(100);
        Console.WriteLine($"Any grade equals 100: {hasPerfectScore}");

        List<string> gradeLabels = grades.ConvertAll(g => $"Grade: {g}");
        Console.WriteLine($"Grade labels: {string.Join(", ", gradeLabels)}");
        #endregion

        #region Question 2
        SortedList<int, string> leaderboard = new()
        {
            { 500, "Ahmed" },
            { 200, "Sara" },
            { 800, "Ali" },
            { 350, "Mona" },
        };

        Console.WriteLine("Leaderboard (sorted by score):");
        foreach (var entry in leaderboard)
        {
            Console.WriteLine($"{entry.Key} - {entry.Value}");
        }

        Console.WriteLine($"First key: {leaderboard.Keys[0]}");
        Console.WriteLine($"First value: {leaderboard.Values[0]}");

        Console.WriteLine($"Score 500 exists: {leaderboard.ContainsKey(500)}");

        string player999 = leaderboard.TryGetValue(999, out var foundPlayer) ? foundPlayer : "No player found";
        Console.WriteLine($"Player with score 999: {player999}");

        leaderboard.Remove(200);
        Console.WriteLine("Leaderboard after removing score 200:");
        foreach (var entry in leaderboard)
        {
            Console.WriteLine($"{entry.Key} - {entry.Value}");
        }
        #endregion

        #region Question 3
        Dictionary<string, string> phoneBook = new()
        {
            { "Ahmed", "010-1111-1111" },
            { "Sara", "010-2222-2222" },
            { "Ali", "010-3333-3333" },
            { "Mona", "010-4444-4444" },
        };

        phoneBook["Omar"] = "010-5555-5555";
        Console.WriteLine("Added contact 'Omar' using [] syntax.");

        try
        {
            phoneBook.Add("Ahmed", "010-9999-9999");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error adding duplicate with .Add(): {ex.Message}");
        }

        bool addedDuplicate = phoneBook.TryAdd("Sara", "010-8888-8888");
        Console.WriteLine($"TryAdd duplicate 'Sara' succeeded: {addedDuplicate}");

        bool foundMissing = phoneBook.TryGetValue("John", out var johnPhone);
        Console.WriteLine($"Searching for 'John': {(foundMissing ? johnPhone : "Not found")}");

        string contactWithFallback = phoneBook.GetValueOrDefault("Layla", "Not Found");
        Console.WriteLine($"Contact 'Layla': {contactWithFallback}");

        Console.WriteLine($"Keys: {string.Join(", ", phoneBook.Keys)}");
        Console.WriteLine($"Values: {string.Join(", ", phoneBook.Values)}");
        #endregion

        #region Question 4
        HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase);
        emails.Add("ahmed@test.com");
        emails.Add("AHMED@test.com");
        emails.Add("sara@test.com");
        emails.Add("Sara@Test.Com");

        // The comparer is case-insensitive, so "AHMED@test.com" and "Sara@Test.Com" are
        // treated as duplicates of the first two entries and are rejected - only 2
        // unique emails actually get stored.
        Console.WriteLine($"Unique email count: {emails.Count}");

        HashSet<int> setA = new() { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new() { 4, 5, 6, 7, 8 };

        HashSet<int> unionResult = new(setA);
        unionResult.UnionWith(setB);
        Console.WriteLine($"UnionWith: {string.Join(", ", unionResult)}");

        HashSet<int> intersectResult = new(setA);
        intersectResult.IntersectWith(setB);
        Console.WriteLine($"IntersectWith: {string.Join(", ", intersectResult)}");

        HashSet<int> exceptResult = new(setA);
        exceptResult.ExceptWith(setB);
        Console.WriteLine($"ExceptWith: {string.Join(", ", exceptResult)}");

        HashSet<int> subsetCheck = new() { 1, 2 };
        Console.WriteLine($"{{1,2}} is subset of Set A: {subsetCheck.IsSubsetOf(setA)}");
        #endregion
    }
}
