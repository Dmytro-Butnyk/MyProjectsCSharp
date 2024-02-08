using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Domain.Models
{
    public class Coin(int lvlValue)
    {
        private int _lvlValue = lvlValue;
        public int LvlValue
        {
            get { return _lvlValue; }
        }
    }
}
