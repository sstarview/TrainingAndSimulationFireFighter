using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAndSimulationFireFighter
{
  class Administrator:INamedPerson,ISalariedPerson
  {
    public decimal Salary { get; set; }
    public string Title { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public string Name
    {
      get
      {
        StringBuilder name = new StringBuilder();
        AppendWithSpace(name, Title);
        AppendWithSpace(name, Forename);
        AppendWithSpace(name, Surname);
        return name.ToString();
      }
    }

    void AppendWithSpace(StringBuilder builder, string stringToAppend)
    {
      // Don't do anything if the string is empty
      if (string.IsNullOrEmpty(stringToAppend))
      {
        return;
      }
      // Add a space if we've got any text already
      if (builder.Length > 0)
      {
        builder.Append(" ");
      }
      builder.Append(stringToAppend);
    }
  }
}
