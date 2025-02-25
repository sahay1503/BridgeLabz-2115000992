using System;

public class LegacyAPI
{
    // Marking the old method as obsolete with a warning message
    [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Executing OldFeature()... (Deprecated)");
    }

    // New method to replace the old one
    public void NewFeature()
    {
        Console.WriteLine("Executing NewFeature()... (Recommended)");
    }
}

public class Program
{
    public static void Main()
    {
        LegacyAPI api = new LegacyAPI();

        // Calling the old method (should show a warning)
        api.OldFeature();

        // Calling the new recommended method
        api.NewFeature();
    }
}
