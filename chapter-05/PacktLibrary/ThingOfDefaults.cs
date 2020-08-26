using System;
using System.Collections.Generic;

namespace Packt.Shared
{
  public class ThingOfDefaults
  {
    public int Population;
    public DateTime When;
    public string Name;
    public List<Person> People;

    public ThingOfDefaults()
    {
      // Commented because this is the old way to do this. The compiler is now smart 
      // enough to determine type as it is already explicitly typed previously
      // Population = default(int); // C# 2.0 and later
      // When = default(DateTime);
      // Name = default(string);
      // People = default(List<Person>);

      // current way to do it as of C# 7.1
      Population = default; // C# 7.1
      When = default;
      Name = default;
      People = default;
    }
  }
}