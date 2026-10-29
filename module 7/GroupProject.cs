class Program
{
  static void Main()
  {
    Dictionary<string, int> dictionary = new Dictionary<string, int>();
    while (true)
    {
      // Write options
      Console.WriteLine("1. Populate the Dictionary");
      Console.WriteLine("2. Display Dictionary Contents");
      Console.WriteLine("3. Remove a Key");
      Console.WriteLine("4. Add a New Key and Value");
      Console.WriteLine("5. Add a Value to an Existing Key");
      Console.WriteLine("6. Sort the Keys");

      Console.Write("Select an option: ");
      // Read input
      string selection = Console.ReadLine();
      Console.WriteLine();

      switch (selection)
      {
        case "1":
          // Populate the Dictionary: Add keys and values determined by your group.
          PopulateDictionary(dictionary);
          break;
        case "2":
          // Display Dictionary Contents: Show the contents of the dictionary using any of the three enumeration methods covered in Module 7.
          DisplayDictionaryContents(dictionary);
          break;
        case "3":
          // Remove a Key: Remove a specified key from the dictionary.
          break;
        case "4":
          // Add a New Key and Value: Insert a new key-value pair into the dictionary.
          break;
        case "5":
          // Add a Value to an Existing Key: Append a new value to an existing key.
          break;
        case "6":
          // Sort the Keys: Sort the keys in the dictionary.
          break;
        default:
          Console.WriteLine("Invalid selection");
          break;
      }
    }
  }

  static void PopulateDictionary(Dictionary<string, int> dictionary)
  {
    try
    {
      // add data to the dictionary
      dictionary.Add("key1", 1);
      dictionary.Add("key2", 2);
    }
    catch (ArgumentException e)
    {
      Console.WriteLine("An error occurred while populating the dictionary: " + e.Message);
    }
  }

  static void DisplayDictionaryContents(Dictionary<string, int> dictionary)
  {
    foreach (KeyValuePair<string, int> kv in dictionary)
      Console.WriteLine(kv.Key + "; " + kv.Value);
    Console.WriteLine();
  }
}