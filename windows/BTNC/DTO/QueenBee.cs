using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BTNC.DTO
{
  public class QueenBee: Bee
  {
    public QueenBee(string name)
    {
      Name = name;
      health = 100;
    }

    public override void Damage(int damagePercentage)
    {
      if (!IsDead)
      {
        if (health < 20)
        {
          Console.WriteLine($"{Name} cannot be damaged further. It is critical.");
          return;
        }
        base.Damage(damagePercentage);
      }
    }
  }
}
