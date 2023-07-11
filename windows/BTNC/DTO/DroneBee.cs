using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNC.DTO
{
  public class DroneBee: Bee
  {
    public DroneBee(string name)
    {
      Name = name;
      health = 100;
    }

    public override void Damage(int damagePercentage)
    {
      if (!IsDead)
      {
        if (health < 50)
        {
          Console.WriteLine($"{Name} cannot be damaged further. It is critical.");
          return;
        }
        base.Damage(damagePercentage);
      }
    }
  }
}
