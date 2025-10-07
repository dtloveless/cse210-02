class Journal
{
    public List<Entry> _entries = new();

    public void Load()
    {
        //import entries from a file to populate _entries list
    }
    
    public void Save()
    {
        //export entries from _entries list to a file
    }

    public void CreateEntry()
    {
        Entry entry = new();

        entry.PromptUser();
        entry.CaptureResponse();

        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}