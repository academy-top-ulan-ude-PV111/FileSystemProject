using System.Text;

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
            //DirectoryInfo dir = new DirectoryInfo("D:\\RPO\\Maxim Efimov");

            //DirectoryInfo[] dirSub = dir.GetDirectories("~*");
            //foreach(var d in dirSub)
            //    Console.WriteLine($"{d.FullName} - {d.Name} - {d.CreationTime}");
            //Console.WriteLine(new String('-', 20));

            //foreach (var f in dir.GetFiles())
            //    Console.WriteLine(f.Name);

            //DirectoryInfo dirWork = new DirectoryInfo(@"work");
            ////dirWork.Create();
            ////dirWork.CreateSubdirectory("images");
            //dirWork.MoveTo(@"hello");

            // File
            // Copy, Create, Delete, Move, Exists
            //File.Create(@"myfile.dat");
            //File.Copy(@"myfile.dat", @"D:\\myfile.max");
            //File.Move(@"myfile.dat", @"D:\\myfile.ddd");
            //File.Delete(@"myfile.dat");


            string[] strs = { "Hello world", "Hello people", "Hello students" };

            File.WriteAllText(@"myfile.txt", "65");
            //File.AppendAllLines(@"myfile.txt", strs, Encoding.Unicode);

            //string text = File.ReadAllText(@"myfile.dat", Encoding.UTF8);
            //Console.WriteLine(text);
            //string[] textStr = File.ReadAllLines(@"myfile.dat");
            //foreach(string str in textStr)
            //    Console.WriteLine(str);

            //File.WriteAllBytes(@"myfile.bin", Encoding.Default.GetBytes("-------\n"));
            byte[] buffer = new byte[1];
            buffer[0] = 65;
            File.WriteAllBytes(@"myfile.bin", buffer);
            // FileInfo
            //FileInfo file = new(@"myfile.dat");
            //Console.WriteLine(file.FullName);
            //Console.WriteLine(file.Name);
            //Console.WriteLine(file.Directory.Name);
            //Console.WriteLine(file.CreationTime);
            //Console.WriteLine(file.Extension);
            //Console.WriteLine(file.Name.Replace(file.Extension, ""));


        }
    }
}