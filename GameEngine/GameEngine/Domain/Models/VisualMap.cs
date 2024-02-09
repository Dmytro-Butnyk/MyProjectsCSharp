using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GameEngine.Domain.Models
{
    public class VisualMap
    {
        private GameMap _map;
        private char[][] _visualMap;
        public VisualMap(GameMap map)
        {
            _map = map;
        }
        private void InitiateMap()
        {
            int rows,
                cols = _map.BackMap[0].Count();
            _visualMap = new char [rows = _map.BackMap.Count()][];
            // initializing char matrix
            for (int i = 0; i < rows; i++)
            {
                _visualMap[i] = new char[cols];
                // filling char matrix
                for(int k = 0; k < cols; k++)
                {
                    _visualMap[i][k] = '■';
                }
            }
        }
        private void DrawObjectColor(object ob, char item) 
        {
            if (ob is Enemy)
            {
                ForegroundColor = ConsoleColor.Red; // Ground color
            }
            else if (ob is Coin)
            {
                ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (ob is MainHero)
            {
                ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                ForegroundColor = ConsoleColor.White;
            }
            Write(item);
            ResetColor();
        }
        public void InitiateVisualMap() 
        {
            InitiateMap();
            for(int i = 0; i < _visualMap.Length; i++)
            {
                for(int k = 0; k < _visualMap[i].Length; k++)
                {
                    DrawObjectColor(_map.BackMap[i][k], _visualMap[i][k]);
                }
                WriteLine();
            }
        }

    }
}
