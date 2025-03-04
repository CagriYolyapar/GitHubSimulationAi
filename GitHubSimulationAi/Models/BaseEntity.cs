using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubSimulationAi.Models
{
    public abstract class BaseEntity
    {
        public string ShipName { get; set; }
        public string ShipShield { get; set; }
        public int ShipHealth { get; set; }
        public int ShipArmor { get; set; }

    }
}
