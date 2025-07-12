public class Entry
{
    public String _date;
    public String _prompText;
    public String _entryText;
    public override string ToString()
{
    
    return $"{_date}|{_prompText}|{_entryText}";
}

    public void Display()
    {


        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();

    }
    

}