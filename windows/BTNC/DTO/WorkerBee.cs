using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNC.DTO
{
  public class WorkerBee: Bee
  {
    public WorkerBee(string name)
    {
      Name = name;
      health = 100;
    }

    public bool CanFly => health >= 70;
  }
}
