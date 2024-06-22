using System.IO;
using System.Security.AccessControl;
using ExceptionProjectLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        //WorkingWithFilesAndDirs();
        //WorkingWIthFileInfoAndDirInfo();

        DateTime dt = new DateTime();

        //string s = DateTime.Now.ToShortDateString();
        //string s1 = DateTime.Now.ToLongTimeString();
        string date= DateTime.Now.ToString("yyyy/MM/ddHHmmssffff");

        string filename = string.Concat("customerLog.txt", date);
        //string path = @"C:\Users\CDAC\Desktop\Shivanjali\DemoFile\demo11.txt";
        string path = @"C:\Users\CDAC\Desktop\Shivanjali\DemoFile\" + filename + ".txt";
        FileStream fs=null;
        StreamWriter sw=null;
        try
        { 
            Customer customer = new Customer();
            Console.WriteLine("Enter customer id..");
            customer.Custid = Convert.ToInt32(Console.ReadLine());
        }
        catch (CustomerNotFoundException ex)
        { 
            fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(ex.Message);
            Console.WriteLine("Completed...");
        }
        finally
        {
            sw.Flush();
            sw.Close();
            fs.Close();
            fs.Dispose();
        }
    }

    private static void WorkingWIthFileInfoAndDirInfo()
    {
        FileInfo fi = new FileInfo(@"C:\Users\CDAC\Desktop\Shivanjali\DemoFile\new files\DemoFile.txt");
        Console.WriteLine(fi.FullName);
        Console.WriteLine(fi.Extension);
        Console.WriteLine(fi.CreationTime);
        Console.WriteLine(fi.DirectoryName);
        FileSecurity fs = fi.GetAccessControl();
        Console.WriteLine(fs.AuditRuleType);

        DirectoryInfo di = new DirectoryInfo(@"C:\DemoFile\new files\");
        Console.WriteLine(di.FullName);
        Console.WriteLine(di.Name);
        Console.WriteLine(di.Parent);
        Console.WriteLine(di.Root);
        Console.WriteLine(di.CreationTime);
    }

    private static void WorkingWithFilesAndDirs()
    {
        string path = @"C:\Users\CDAC\Desktop\Shivanjali\DemoFile\";
        //Directory.CreateDirectory(path +"Dir1");
        //File.Move(path + "DemoFile2.txt",path+ "Dir1\\DemoFile2.txt");
        //File.Move(path + "file1.pdf", path + "Dir1\\file1.pdf");
        //File.Move(path + "file2.pdf", path + "Dir1\\file2.pdf");

        Console.WriteLine("File 2 is moved in dir1");
        string[] files = Directory.GetFiles(path + "Dir1\\");
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        string fullpath = @"C:\Users\CDAC\Desktop\Shivanjali\FileHandlingDemo\FileHandlingDemo\";
        IEnumerable<string> dirs = Directory.EnumerateDirectories(fullpath);
        foreach (var item in dirs)
        {
            Console.WriteLine(item);
        }
        bool isFound = Directory.Exists(path);
        Console.WriteLine(isFound);


        //string p = string.Concat(path+"DemoFile.txt");
        //string destpatch = string.Concat(path + "DemoFile2.txt");
        //string P = "C:/Users/CDAC/Desktop/Shivanjali/DemoFile/";
        //File.Create(path + "DemoFile.txt");
        //File.AppendAllText(path + "DemoFile.txt", "This is a Demo file.it is created by Shivanjali gadekar");

        //File.Copy(p, destpatch);
        //Console.WriteLine("File is Created...");

        //File.Delete(destpatch);
        //Console.WriteLine("File is Deleted...");

        //string contents= File.ReadAllText(p);
        //Console.WriteLine(contents);
        //Console.WriteLine("In this file read all text ");


        //string source = path + "DemoFile.txt";
        //string dest = path + "new files\\DemoFile.txt";
        //File.Move(source,dest);
        //Console.WriteLine("file is moved");
    }
}