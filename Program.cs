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
    }
}
