public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _tag;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Tag: {_tag}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }
}
