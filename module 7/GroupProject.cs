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
      string selection = Console.ReadLine() ?? string.Empty;
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
          RemoveKey(dictionary);
          break;
        case "4":
          // Add a New Key and Value: Insert a new key-value pair into the dictionary.
          AddNewKeyValue(dictionary);
          break;
        case "5":
          // Add a Value to an Existing Key: Append a new value to an existing key.
          AddValueToExistingKey(dictionary);
          break;
        case "6":
          // Sort the Keys: Sort the keys in the dictionary.
          SortKeys(dictionary);
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

  static void RemoveKey(Dictionary<string, int> dictionary)
  {
    // take input
    Console.Write("Enter the key to remove: ");
    string key = Console.ReadLine() ?? string.Empty;

    // remove key and display result
    if (dictionary.Remove(key))
      Console.WriteLine("Key removed successfully.");
    else
      Console.WriteLine("Key not found.");
  }
  static void AddNewKeyValue(Dictionary<string, int> dictionary)
  {
    try
    {
      // take input for the new key and value
      Console.Write("Enter the new key: ");
      string key = Console.ReadLine() ?? string.Empty;

      Console.Write("Enter the value: ");
      int value = int.Parse(Console.ReadLine() ?? string.Empty);

      // add the new key and value to the dictionary
      dictionary.Add(key, value);
      Console.WriteLine("Key and value added successfully.");
    }
    catch (FormatException e)
    {
      Console.WriteLine("Error: The value must be a valid integer. " + e.Message);
    }
    catch (ArgumentException e)
    {
      Console.WriteLine("Error adding the key and value: " + e.Message);
    }
  }

  static void AddValueToExistingKey(Dictionary<string, int> dictionary)
  {
    try
    {
      // take input for the key to update
      Console.Write("Enter the key to update: ");
      string key = Console.ReadLine() ?? string.Empty;
      // check if the key exists in the dictionary
      if (!dictionary.ContainsKey(key))
      {
        Console.WriteLine("Error: Key not found.");
        return;
      }

      Console.Write("Enter the new value for the key: ");
      int value = int.Parse(Console.ReadLine() ?? string.Empty);

      // update value in dictionary
      dictionary[key] = value;
      Console.WriteLine("Value updated successfully.");
    }
    catch (FormatException e)
    {
      Console.WriteLine("Error: The value must be a valid integer. " + e.Message);
    }
  }

  static void SortKeys(Dictionary<string, int> dictionary)
  {
    // copy dictionary
    Dictionary<string, int> values = new Dictionary<string, int>(dictionary);
    // create list out of keys
    List<string> sortedKeys = new List<string>(dictionary.Keys);
    // sort the keys
    sortedKeys.Sort();
    // clear dictionary
    dictionary.Clear();

    foreach (string key in sortedKeys)
    {
      // add sorted keys and values back to the dictionary
      dictionary.Add(key, values[key]);
    }
  }
}