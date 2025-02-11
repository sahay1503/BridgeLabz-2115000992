using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        SocialMedia socialNetwork = new SocialMedia();

        socialNetwork.AddUser(1, "Amit", 25);
        socialNetwork.AddUser(2, "Priya", 22);
        socialNetwork.AddUser(3, "Rahul", 27);
        socialNetwork.AddUser(4, "Sneha", 24);
        socialNetwork.AddUser(5, "Vikram", 30);

        socialNetwork.AddFriend(1, 2);
        socialNetwork.AddFriend(1, 3);
        socialNetwork.AddFriend(2, 4);
        socialNetwork.AddFriend(3, 5);
        socialNetwork.AddFriend(4, 5);
        socialNetwork.AddFriend(2, 5);

        socialNetwork.DisplayFriends(2);
        socialNetwork.FindMutualFriends(2, 5);
        socialNetwork.CountFriends();
    }
}