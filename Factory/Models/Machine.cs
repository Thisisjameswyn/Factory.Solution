using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int MachineId { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }

    public int MyInt { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }

    public string NameNumber
    {
      get
      {
        return Name + Number;
      }
    }
  }
}