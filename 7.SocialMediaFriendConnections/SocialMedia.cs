class SocialMedia
{
    private User head;

    public void AddUser(int userID, string name, int age)
    {
        User newNode = new User(userID, name, age);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            User temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    public User FindUser(int userID)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void AddFriend(int userID1, int userID2)
    {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);

        if (user1 != null && user2 != null)
        {
            if (!user1.FriendIDs.Contains(userID2))
                user1.FriendIDs.Add(userID2);

            if (!user2.FriendIDs.Contains(userID1))
                user2.FriendIDs.Add(userID1);

            Console.WriteLine($"Friend connection added between {user1.Name} and {user2.Name}");
        }
        else
        {
            Console.WriteLine("One or both users not found.");
        }
    }

    public void RemoveFriend(int userID1, int userID2)
    {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);

        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);

            Console.WriteLine($"Friend connection removed between {user1.Name} and {user2.Name}");
        }
        else
        {
            Console.WriteLine("One or both users not found.");
        }
    }

    public void DisplayFriends(int userID)
    {
        User user = FindUser(userID);
        if (user != null)
        {
            Console.WriteLine($"Friends of {user.Name}:");
            foreach (var friendID in user.FriendIDs)
            {
                User friend = FindUser(friendID);
                Console.WriteLine($"- {friend.Name} (ID: {friend.UserID})");
            }
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void FindMutualFriends(int userID1, int userID2)
    {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);

        if (user1 != null && user2 != null)
        {
            HashSet<int> mutualFriends = new HashSet<int>(user1.FriendIDs);
            mutualFriends.IntersectWith(user2.FriendIDs);

            Console.WriteLine($"Mutual friends between {user1.Name} and {user2.Name}:");
            foreach (var friendID in mutualFriends)
            {
                User friend = FindUser(friendID);
                Console.WriteLine($"- {friend.Name} (ID: {friend.UserID})");
            }
        }
        else
        {
            Console.WriteLine("One or both users not found.");
        }
    }

    public void CountFriends()
    {
        User temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} has {temp.FriendIDs.Count} friends.");
            temp = temp.Next;
        }
    }
}