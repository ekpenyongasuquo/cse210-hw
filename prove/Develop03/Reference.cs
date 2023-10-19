using System;


public class Reference
{

    public List<Reference> _reference = new List<Reference>();
    private string _fileName = "DataText.txt";
    private string _key;
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;


    public void LoadReference()
    {
        List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Reference entry = new Reference();

            entry._key = entries[0];
            entry._book = entries[1];
            entry._chapter = int.Parse(entries[2]);
            entry._verseStart = int.Parse(entries[3]);
            entry._verseEnd = int.Parse(entries[4]);

            _reference.Add(entry);
        }
    }

    public void ReferenceDisplay()
    {
        foreach (Reference item in _reference)
        {

            if (item._verseEnd.Equals(0))
            {
                item.ReferenceOne();
            }
            else
            {
                item.ReferenceTwo();
            }
        }
    }
    public string GetReference(Scripture scripture)
    {
        var index = scripture._index;

        var refi = _reference[index];
        string ref1;
        if (refi._verseEnd.Equals(0))
        {
            return ref1 = ($"\n{refi._book} {refi._chapter}:{refi._verseStart}");

        }
        else
        {
            return ref1 = $"\n{refi._book} {refi._chapter}:{refi._verseStart}-{refi._verseEnd}";
        }
    }


    public void ReferenceOne()
    {
        Console.WriteLine($"\n{_book} {_chapter}:{_verseStart}");
    }
    public void ReferenceTwo()
    {
        Console.WriteLine($"\n{_book} {_chapter}:{_verseStart}-{_verseEnd}");
    }
}


