using System.Diagnostics;

public class UsingMyGhostScript
{
    public static void Extract(string fileName)
    {
        //string fileName = "cnis";
        string relativePath = "files/" + fileName;
        string absolutePath = System.IO.Path.GetFullPath(relativePath);
        string inputFilePath = $"{absolutePath}.pdf";
        string outputFilePath =  $"{absolutePath}_ghostscript_{DateTime.Now.ToString("yyyMMdd-mmss")}.txt";;

        Process process = new Process();
        process.StartInfo.FileName = "gswin64c.exe";
        process.StartInfo.Arguments = string.Format("-sDEVICE=txtwrite -o \"{0}\" \"{1}\"", outputFilePath, inputFilePath);
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.UseShellExecute = false;
        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Console.WriteLine(new string('*', 100));
        Console.WriteLine("The process ended");
        Console.WriteLine(new string('*', 100));
    }
}