using System;
using System.Collections.Generic;

class VotingSystem
{
    private Dictionary<string, int> voteCount = new Dictionary<string, int>();
    private List<string> voteOrder = new List<string>();

    public void CastVote(string candidate)
    {
        if (voteCount.ContainsKey(candidate))
        {
            voteCount[candidate]++;
        }
        else
        {
            voteCount[candidate] = 1;
        }
        voteOrder.Add(candidate);
    }

    public void DisplayVotes()
    {
        Console.WriteLine("\nVote Count:");
        foreach (var pair in voteCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} votes");
        }
    }

    public void DisplayVotesInSortedOrder()
    {
        Console.WriteLine("\nSorted Vote Count (Alphabetical Order):");
        SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(voteCount);

        foreach (var pair in sortedVotes)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} votes");
        }
    }

    public void DisplayVoteOrder()
    {
        Console.WriteLine("\nVote Order:");
        foreach (var candidate in voteOrder)
        {
            Console.Write(candidate + " -> ");
        }
        Console.WriteLine("End");
    }
}

class Program
{
    static void Main()
    {
        VotingSystem votingSystem = new VotingSystem();

        Console.WriteLine("Voting System - Enter candidate names to vote. Type 'exit' to stop voting.");

        while (true)
        {
            Console.Write("Enter candidate name (or 'exit' to finish): ");
            string candidate = Console.ReadLine().Trim();

            if (candidate.ToLower() == "exit")
                break;

            if (!string.IsNullOrEmpty(candidate))
            {
                votingSystem.CastVote(candidate);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid candidate name.");
            }
        }
        votingSystem.DisplayVotes();
        votingSystem.DisplayVotesInSortedOrder();
        votingSystem.DisplayVoteOrder();
    }
}
