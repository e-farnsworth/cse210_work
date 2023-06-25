using System.IO;

public class Journal
{
    public string _fileName;
    public List<Entry> _entries = new List<Entry>();




    public void AddEntry()
    {
        Entry _entry = new Entry();

        DateTime currentDate = DateTime.Now;
        _entry._date = currentDate.ToShortDateString();
        //string prompt = RandomPrompt();
        _entry._prompt = "_randomPrompt";
        Console.WriteLine($"Prompt: {_entry._prompt}");
        Console.Write("Journal Entry: ");
        _entry._newEntry = Console.ReadLine();

        _entries.Add(_entry);

    }

    public void SaveEntries()
    {
        
        Console.WriteLine("Enter the filename to save the journal (example.txt):");
        _fileName = Console.ReadLine(); 

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}||{entry._prompt}||{entry._newEntry}");
            }
        }
        Console.WriteLine("Journal Saved Succesfully.");
        
    }

    public void LoadEntries()
    {
        

        Console.WriteLine("Enter the filename to load the journal (example.txt):");
        _fileName = Console.ReadLine();
        
        _entries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            Entry _entry = new Entry();
            string[] parts = line.Split("||");

            _entry._date = parts[0];
            _entry._prompt = parts[1];
            _entry._newEntry = parts[2];

            _entries.Add(_entry);
        }

        Console.WriteLine("Journal Loaded Succesfully.");
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_fileName}");
        Console.WriteLine("Entries:");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

}