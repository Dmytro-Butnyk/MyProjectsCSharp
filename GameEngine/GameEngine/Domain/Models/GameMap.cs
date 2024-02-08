using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Domain.Models
{
    public class GameMap
    {
        private List<List<object>> _backMap;

        public GameMap()
        {
            _backMap = new List<List<object>>();
        }
        public GameMap(List<List<object>> backMap, List<List<char>> map)
        {
            _backMap = backMap;
        }
        public List<List<object>> BackMap
        {
            get { return _backMap; }
        }
    }
}
