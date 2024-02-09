using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Domain.Models
{
    public class GameMap
    {
        private List<List<dynamic>> _backMap;

        public GameMap()
        {
            _backMap = new List<List<dynamic>>();
        }
        public GameMap(List<List<dynamic>> backMap)
        {
            _backMap = backMap;
        }
        public List<List<dynamic>> BackMap
        {
            get { return _backMap; }
        }
    }
}
