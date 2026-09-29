
class Octopus
{
  public readonly string Name;
  public readonly int Legs = 8;
  
  public Octopus (string name)
  {
    Name = name;
  }
}

class Species : Octopus
{
  public readonly string SpeciesName;
  public Species(string name, string speciesName) : base(name)
  {
    SpeciesName = speciesName;
  }
}

class Program
{
  static void Main()
  {
    var Octopus1 = new Species("Octo", "Common Octopus");
    var Octopus2 = new Species("Jack", "Atlantic Longarm Octopus");

    Console.WriteLine(Octopus1.Name);
    Console.WriteLine(Octopus1.Legs);
    Console.WriteLine(Octopus1.SpeciesName);
    Console.WriteLine(Octopus2.Name);
    Console.WriteLine(Octopus2.Legs);
    Console.WriteLine(Octopus2.SpeciesName);
  }
}