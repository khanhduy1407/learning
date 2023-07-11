using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNC.DTO
{
  public class BeeManager
  {
    private List<Bee> bees;

    public void CreateBeeList()
    {
      bees = new List<Bee>();

      Random random = new Random();

      for (int i = 0; i < 3; i++)
      {
        WorkerBee workerBee = new WorkerBee($"Worker Bee {i + 1}");
        bees.Add(workerBee);

        QueenBee queenBee = new QueenBee($"Queen Bee {i + 1}");
        bees.Add(queenBee);

        DroneBee droneBee = new DroneBee($"Drone Bee {i + 1}");
        bees.Add(droneBee);
      }
    }

    public void AttackBees()
    {
      Random random = new Random();

      foreach (Bee bee in bees)
      {
        if (!bee.IsDead)
        {
          int damagePercentage = random.Next(0, 81);
          bee.Damage(damagePercentage);
        }
      }
    }

    public void DisplayBeeStatus()
    {
      foreach (Bee bee in bees)
      {
        // string beeType = bee.GetType().Name;
        string healthStatus = bee.IsDead ? "Dead" : "Alive";
        Console.WriteLine($"{bee.Name}: Health - {bee.Health}%, Status - {healthStatus}");
      }
    }
  }
}
