namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs();
            FilesCount();
        }

        static void GetCatalogs()
        {
            string dirName = @"C:\\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);

                foreach (string d in dirs)
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);

                foreach (string s in files)
                    Console.WriteLine(s);
            }

        }

        static void FilesCount()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo(@"C:\\newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}