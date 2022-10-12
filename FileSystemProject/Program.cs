namespace FileSystemProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// DriveInfo
            //DriveInfo[] drivers = DriveInfo.GetDrives();

            //foreach (DriveInfo driver in drivers)
            //{
            //    Console.WriteLine($"Name: {driver.Name}");
            //    Console.WriteLine($"Type: {driver.DriveType}");
            //    Console.WriteLine($"Root Dir: {driver.RootDirectory}");

            //    if (driver.IsReady)
            //    {
            //        Console.WriteLine($"Label: {driver.VolumeLabel}");
            //        Console.WriteLine($"Total size: {driver.TotalSize}");
            //        Console.WriteLine($"Total free size: {driver.TotalFreeSpace}");

            //    }

            //    Console.WriteLine(new String('-', 20));
            //}
            //Console.ReadKey();

            // Directory
            //DirectoryInfo dirWork = Directory.CreateDirectory("work");
            //Directory.Delete("work");
            //Console.WriteLine(Directory.Exists("work"));
            //Console.WriteLine(Directory.GetCurrentDirectory());
            //Console.WriteLine($"Directories");
            //foreach (var dir in Directory.GetDirectories("work"))
            //    Console.WriteLine(dir);
            //Console.WriteLine(new String('-', 20));

            //Console.WriteLine($"Files");
            //foreach (var file in Directory.GetFiles("work"))
            //    Console.WriteLine(file);
            //Console.WriteLine(new String('-', 20));

            //Console.WriteLine($"Full info");
            //foreach (var item in Directory.GetFileSystemEntries("work"))
            //    Console.WriteLine(item);
            //Console.WriteLine(new String('-', 20));

            //Console.WriteLine(Directory.GetParent("work"));
            //Console.WriteLine(Directory.GetCreationTime("work"));
            //Console.WriteLine(Directory.GetLastWriteTime("work"));
            //Console.WriteLine(Directory.GetLastAccessTime("work"));
            //Console.WriteLine(new String('-', 20));

            // DirectoryInfo
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());


        }
    }
}