using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Domain.Models
{
    public class VisualMap
    {
        private GameMap _map;
        private List<List<char>> _visualMap;
        public VisualMap(GameMap map)
        {
            _map = map;
        }
        public void VirtualizeMap()
        {
            _visualMap = new List<List<char>>();
            foreach(var item in _map.BackMap)
            {
                 
            }
        }
    }
}
