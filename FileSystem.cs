public class FileSystem
{
    public static void listDirectories(string dirName)
    {
        //Grab the directories in a given directory 
        IEnumerable<string> dirs = Directory.EnumerateDirectories(dirName);
        foreach (var dir in dirs)
        {
            Console.WriteLine(dir);
        }
    }

    public static void listFiles(string dirName)
    {
        //Grab the directories in a given directory 
        IEnumerable<string> dirs = Directory.EnumerateFiles(dirName);
        foreach (var dir in dirs)
        {
            Console.WriteLine(dir);
        }
    }

    public static void listAllContents(string dirName, string format)
    {
        //Grab the directories in a given directory 
        // Find all *.txt files in the stores folder and its subfolders
        IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles(dirName, format, SearchOption.AllDirectories);

        foreach (var file in allFilesInAllFolders)
        {
            Console.WriteLine(file);
        }

        var currentDirectory = Directory.GetCurrentDirectory();
        Console.WriteLine($"The current directory is {currentDirectory} ");

        Console.WriteLine($"File path : dirName{Path.DirectorySeparatorChar}fileName");

        Console.WriteLine(Path.Combine("adeleke", "bright"));

        Console.WriteLine($"The extension is  : {Path.GetExtension("names.json")}");
    }

    public IEnumerable<string> findFile(string dirName, string format)
    {
        List<string> allFiles = new List<string>();
        IEnumerable<string> dirs = Directory.EnumerateFiles(dirName, "*", SearchOption.AllDirectories);

        foreach (var file in dirs)
        {
            if (file.EndsWith(format))
            {
                allFiles.Add(file);
            }
        }
        return allFiles;
    }

    public static string getFileInfo(string file)
    {
        var currentDirectory = $"{Directory.GetCurrentDirectory()}";

        var f = $"{Path.Combine(currentDirectory, file)}";

        FileInfo fileInfo = new FileInfo(f);

        return $"Name : {fileInfo.FullName} , Ext : {fileInfo.Extension}";
    }

    public static void addDirectoryAndFile(string dirName, string fileName, string mode)
    {
        try
        {
            if (Directory.Exists(dirName))
            {

                Console.WriteLine("Directory already exists");
                //return;
            }
            if (mode == "r")
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), Path.Combine(dirName, fileName));
                var content = File.ReadAllText(filePath);
                Console.WriteLine(content);
                return;
            }
            if (mode == "a")
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), Path.Combine(dirName, fileName));
                File.AppendAllText(filePath, "\nThis is an append");
                var content = File.ReadAllText(filePath);
                Console.WriteLine(content);
                return;
            }
            var dir = $"{Directory.CreateDirectory(dirName)}";
            File.WriteAllText(Path.Combine(dir, fileName), "Hello,  John");
            Console.WriteLine("File Added successfully");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}