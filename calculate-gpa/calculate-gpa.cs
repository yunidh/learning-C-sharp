using System.Text.Json;

class Program
{
    // Semester structure with name and total credits
    static readonly Dictionary<string, int> semesterCredits = new Dictionary<string, int>
    {
        { "1st year/1st semester", 18 }, // Year 1, Semester 1
        { "1st year/2nd semester", 20 }, // Year 1, Semester 2
        { "2nd year/1st semester", 18 }, // Year 2, Semester 1
        { "2nd year/2nd semester", 18 }, // Year 2, Semester 2
        { "3rd year/1st semester", 20 }, // Year 3, Semester 1
        { "3rd year/2nd semester", 19 }, // Year 3, Semester 2
        { "4th year/1st semester", 12 }, // Year 4, Semester 1
        { "4th year/2nd semester", 15 }, // Year 4, Semester 2
    };

    static readonly string SaveDirectory = "saved_results";

    static void Main()
    {
        // Ensure save directory exists
        Directory.CreateDirectory(SaveDirectory);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Computer Engineering CGPA Calculator ===\n");
            Console.WriteLine("1. New Result");
            Console.WriteLine("2. Load Result");
            Console.WriteLine("3. Exit\n");
            Console.Write("Choose an option (1-3): ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    CalculateNewResult();
                    break;
                case "2":
                    LoadResult();
                    break;
                case "3":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void CalculateNewResult()
    {
        Console.Clear();
        Console.WriteLine("=== New CGPA Calculation ===\n");

        List<string> semesters = new List<string>
        {
            "1st year/1st semester",
            "1st year/2nd semester",
            "2nd year/1st semester",
            "2nd year/2nd semester",
            "3rd year/1st semester",
            "3rd year/2nd semester",
            "4th year/1st semester",
            "4th year/2nd semester",
        };
        Dictionary<string, double> semesterGPAs = new Dictionary<string, double>();

        // Input GPAs for each semester
        foreach (var semester in semesters)
        {
            Console.Write($"Enter GPA for {semester} (0-4.0, or press Enter to skip): ");
            string input = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(input))
            {
                break; // Stop if user presses Enter without input
            }

            if (double.TryParse(input, out double gpa) && gpa >= 0 && gpa <= 4.0)
            {
                semesterGPAs[semester] = gpa;
            }
            else
            {
                Console.WriteLine("Invalid GPA. Please enter a value between 0 and 4.0.");
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
                return;
            }
        }

        if (semesterGPAs.Count == 0)
        {
            Console.WriteLine("No GPA data entered.");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            return;
        }

        // Calculate and display results
        DisplayResults(semesterGPAs);

        // Save prompt
        Console.WriteLine(
            "\n\nPress 'S' to Save Result and Exit | Press 'Esc' to Exit without Saving"
        );
        var key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.S)
        {
            SaveResult(semesterGPAs);
        }
    }

    static void DisplayResults(Dictionary<string, double> semesterGPAs)
    {
        // Calculate CGPA
        double totalGradePoints = 0;
        int totalCredits = 0;

        Console.WriteLine("\n=== Semester Summary ===");
        foreach (var entry in semesterGPAs)
        {
            string semester = entry.Key;
            double gpa = entry.Value;
            int credits = semesterCredits[semester];

            double gradePoints = gpa * credits;
            totalGradePoints += gradePoints;
            totalCredits += credits;

            Console.WriteLine(
                $"{semester}: GPA = {gpa:F2}, Credits = {credits}, Grade Points = {gradePoints:F2}"
            );
        }

        double cgpa = totalGradePoints / totalCredits;

        Console.WriteLine("\n=== Final Results ===");
        Console.WriteLine($"Total Credits Completed: {totalCredits}");
        Console.WriteLine($"Total Grade Points: {totalGradePoints:F2}");
        Console.WriteLine($"Cumulative GPA (CGPA): {cgpa:F4}");
        Console.WriteLine($"Percentage: {(cgpa / 4.0) * 100:F2}%");
        Console.WriteLine($"Classification: {GetClassification(cgpa)}");
    }

    static void SaveResult(Dictionary<string, double> semesterGPAs)
    {
        Console.Write("\nEnter a name for this result: ");
        string name = Console.ReadLine() ?? "unnamed";

        // Sanitize filename
        foreach (char c in Path.GetInvalidFileNameChars())
        {
            name = name.Replace(c, '_');
        }

        string filename = Path.Combine(SaveDirectory, $"{name}.json");

        try
        {
            var data = new
            {
                Name = name,
                Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                SemesterGPAs = semesterGPAs,
            };

            string jsonString = JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions { WriteIndented = true }
            );
            File.WriteAllText(filename, jsonString);

            Console.WriteLine($"\nResult saved successfully as '{name}'!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError saving file: {ex.Message}");
        }

        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }

    static void LoadResult()
    {
        Console.Clear();
        Console.WriteLine("=== Load Saved Result ===\n");

        var files = Directory.GetFiles(SaveDirectory, "*.json");

        if (files.Length == 0)
        {
            Console.WriteLine("No saved results found.");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Saved Results:");
        for (int i = 0; i < files.Length; i++)
        {
            string name = Path.GetFileNameWithoutExtension(files[i]);
            Console.WriteLine($"{i + 1}. {name}");
        }

        Console.Write("\nEnter the number of the result to load (or 0 to cancel): ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int choice) && choice > 0 && choice <= files.Length)
        {
            try
            {
                string jsonString = File.ReadAllText(files[choice - 1]);
                var data = JsonSerializer.Deserialize<JsonElement>(jsonString);

                var semesterGPAs = new Dictionary<string, double>();
                foreach (var property in data.GetProperty("SemesterGPAs").EnumerateObject())
                {
                    semesterGPAs[property.Name] = property.Value.GetDouble();
                }

                Console.Clear();
                Console.WriteLine($"=== Loaded Result: {data.GetProperty("Name").GetString()} ===");
                Console.WriteLine($"Date Saved: {data.GetProperty("Date").GetString()}\n");

                DisplayResults(semesterGPAs);

                Console.WriteLine("\n\nPress any key to return to menu...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError loading file: {ex.Message}");
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
            }
        }
    }

    static string GetClassification(double cgpa)
    {
        if (cgpa >= 3.8)
            return "Distinction (Outstanding)";
        if (cgpa >= 3.5)
            return "First Class (Excellent)";
        if (cgpa >= 3.0)
            return "Second Class Upper (Very Good)";
        if (cgpa >= 2.5)
            return "Second Class Lower (Good)";
        if (cgpa >= 2.0)
            return "Pass";
        return "Fail";
    }
}
