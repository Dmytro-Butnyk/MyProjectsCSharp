using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Domain.Models
{
    public class Enemy : Character
    {
        private int _lvl;
        public Enemy():base(10, 5)
        {
            _lvl = 1;
        }
        public Enemy(int lvl):base(lvl * 10, lvl * 5)
        {
            _lvl = lvl;
        }
        public override string ToString()
        {
            return $"Enemy:\n" + base.ToString() +
                $"|Level: {_lvl}|";
        }
    }
}
