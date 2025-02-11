class User
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public User Next;

    public User(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}