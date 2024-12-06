using Microsoft.Win32.SafeHandles;

string filepath = "tekstfil.txt"; // lager en variabel som peker til filepathen til tekstfilen min

if (!File.Exists(filepath)) // hvis den fil ikke eksisterer i filepathen:
{
    using (StreamWriter streamWriter = File.CreateText(filepath)) //bruke streamwriter til å lage en tekstfil med filepath prosjekt/tekstfil.txt
    {
        streamWriter.WriteLine("Dette");    // skriver det som skal inn i filen.
        streamWriter.WriteLine("er");
        streamWriter.Write("en ");
        streamWriter.WriteLine("tekstfil");
        streamWriter.WriteLine("med");
        streamWriter.Write("en ");
        streamWriter.WriteLine("text");
    }
}

using (StreamReader streamReader = File.OpenText(filepath)) // bruker StreamReader til å åpne og lese teksten i filen.
{
    string? line; // lager en strengvariabel line
    while ((line = streamReader.ReadLine()) != null) // så lenge det er en tekst på en linje(den leser ikke null), les og skriv ut teksten i console
    {
        Console.WriteLine(line);
    }
}

// File.WriteAllText(filepath, string.Empty);
// File.Delete(filepath);




