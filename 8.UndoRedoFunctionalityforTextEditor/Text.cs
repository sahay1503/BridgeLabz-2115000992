class Text
{
    public string Content;
    public Text Prev, Next;

    public Text(string content)
    {
        Content = content;
        Prev = Next = null;
    }
}
