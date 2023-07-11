using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNC.DTO
{
  public abstract class Bee
  {
    protected int health;
    public string Name { get; set; }

    public int Health => health;

    public bool IsDead => health <= 0;

    public virtual void Damage(int damagePercentage)
    {
      if (!IsDead)
      {
        int damage = (health * damagePercentage) / 100;
        health -= damage;
        if (health < 3)
        {
          health = 0;
        }
      }
    }
  }
}
