using GameEngine.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Domain.Models
{
    public class Ground(GroundType type)
    {
        private GroundType _type = type; 
    }
}
