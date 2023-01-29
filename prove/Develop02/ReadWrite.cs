using System.IO; 
public class ReadWrite
{
    public List<Entry> _ReadingList = new List<Entry>();
    public void WriteFile()
    {
        Console.WriteLine("Filename: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry currentEntry in _ReadingList)
            {
                outputFile.WriteLine($"{currentEntry._Date} ; {currentEntry._Prompt} ; {currentEntry._UserText}");
            }
        }
    }

    public void ReadFile()
    {
            Console.WriteLine("Filename: ");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    Entry Entry1 = new Entry();
                    string[] parts = line.Split(";");
                    Entry1._Date = parts[0];
                    Entry1._Prompt = parts[1];
                    Entry1._UserText = parts[2];
                    _ReadingList.Add(Entry1);
                }
    }
    public void Display()
    {
                    foreach (Entry currentEntry in _ReadingList)
                    {
                        Console.WriteLine($"{currentEntry._Date}, {currentEntry._Prompt} {currentEntry._UserText}");
                    }

    }
    public void deleteFile()
    {
        Console.WriteLine("Filename: ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine("File deleted successfully.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }    
}