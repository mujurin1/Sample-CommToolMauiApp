namespace CommToolMauiApp.Model;

internal interface IItem
{
    string Title { get; }
    int Count { get; }
    bool Checked { get; }
}

internal record Item(string Title) : IItem
{
    public int Count { get; init; } = 0;
    public bool Checked { get; init; } = false;
}


