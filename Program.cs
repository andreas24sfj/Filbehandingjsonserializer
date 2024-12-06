using Microsoft.Win32.SafeHandles;

string filepath = "tekstfil.txt";

if (!File.Exists(filepath))
{
    using (StreamWriter streamWriter = File.CreateText(filepath))
    {
        streamWriter.WriteLine("Dette");
        streamWriter.WriteLine("er");
        streamWriter.Write("en ");
        streamWriter.WriteLine("tekstfil");
        streamWriter.WriteLine("med");
        streamWriter.Write("en ");
        streamWriter.WriteLine("text");
    }
}

using (StreamReader streamReader = File.OpenText(filepath))
{
    string? line;
    while ((line = streamReader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// File.WriteAllText(filepath, string.Empty);
// File.Delete(filepath);




