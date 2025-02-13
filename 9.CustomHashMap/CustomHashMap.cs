public class CustomHashMap
{
    private const int SIZE = 100; // Fixed size for simplicity
    private LinkedList<KeyValuePair<int, int>>[] map;

    public CustomHashMap()
    {
        map = new LinkedList<KeyValuePair<int, int>>[SIZE];
    }
    // Hash function to get index
    private int GetHash(int key)
    {
        return Math.Abs(key) % SIZE;
    }
    // Insert or Update key-value pair
    public void Put(int key, int value)
    {
        int index = GetHash(key);
        if (map[index] == null)
            map[index] = new LinkedList<KeyValuePair<int, int>>();

        foreach (var pair in map[index])
        {
            if (pair.Key == key)
            {
                map[index].Remove(pair);
                break;
            }
        }
        map[index].AddLast(new KeyValuePair<int, int>(key, value));
        Console.WriteLine($"Inserted: Key = {key}, Value = {value}");
    }
    // Retrieve value for a given key
    public int Get(int key)
    {
        int index = GetHash(key);
        if (map[index] != null)
        {
            foreach (var pair in map[index])
            {
                if (pair.Key == key)
                    return pair.Value;
            }
        }
        return -1; // Key not found
    }
    // Remove key-value pair
    public void Remove(int key)
    {
        int index = GetHash(key);
        if (map[index] != null)
        {
            foreach (var pair in map[index])
            {
                if (pair.Key == key)
                {
                    map[index].Remove(pair);
                    Console.WriteLine($"Removed key {key}");
                    return;
                }
            }
        }
        Console.WriteLine($"Key {key} not found!");
    }
    // Display all key-value pairs
    public void Display()
    {
        Console.WriteLine("\n--- HashMap Contents ---");
        for (int i = 0; i < SIZE; i++)
        {
            if (map[i] != null)
            {
                foreach (var pair in map[i])
                {
                    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
                }
            }
        }
    }
}
