/////////////////DATA////////////////
using System.Threading.Tasks.Dataflow;

List<string> datalist = new List<string>();
string data = "data.txt";

if (File.Exists(data))
{
    string[] datalarim = File.ReadAllLines(data);

    for (int i = 0; i < datalarim.Length; i++)
    {
        datalist.Add(datalarim[i]);
    }
}

////////////////SYSTEM//////////////////

Console.WriteLine("WELCOME!");
filepatch();
Console.WriteLine("Press any button to see the data.");
Console.WriteLine("Quit: Q");

while (true)
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Program exited.");
                break;
            }
            else
            {
                datasee();
            }
        }
    }

void filepatch()
{
    while (true)
    {
        Console.Write("File Patch: ");
        string patch = Console.ReadLine();

        if (!Directory.Exists(patch))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            Console.WriteLine("System successful");
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = patch;
            watcher.IncludeSubdirectories = true;
            watcher.Filter = "*.*";

            watcher.Created += OnIncident;
            watcher.Changed += OnIncident;
            watcher.Deleted += OnIncident;
            watcher.Renamed += OnIncident;

            watcher.EnableRaisingEvents = true;
            Console.WriteLine($"📡 '{patch}' File is followed...");
            break;
        }
    }
}

void OnIncident(object sender,FileSystemEventArgs e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("------------");
    Console.WriteLine($"New Incident: \nName: {e.Name} \nPath: {e.FullPath} \nIncedent: {e.ChangeType}");
    Console.ResetColor();
    DateTime zaman = DateTime.Now;
    string text = $"{e.Name} --> {e.FullPath} --> {e.ChangeType} --> {zaman}";
    datalist.Add(text);
    File.WriteAllLines(data,datalist);
}

void datasee()
{
    Console.WriteLine("------------");
    if (datalist.Count == 0)
    {
        Console.WriteLine("Not Data!");
    }
    else
    {
        Console.WriteLine("ID - NAME - PATH - INCIDENT - DATE");
    }
    for (int i = 0; i < datalist.Count; i++)
    {
        Console.WriteLine($"{i + 1}-{datalist[i]}");
    }
}



