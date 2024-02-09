// See https://aka.ms/new-console-template for more information
using GameEngine.Domain.Enums;
using GameEngine.Domain.Models;
using static System.Console;

GameMap gameMap = new(new List<List<dynamic>>());
gameMap.BackMap.Add(new List<dynamic>());

gameMap.BackMap[0].Add(new Ground(GroundType.ground));
gameMap.BackMap[0].Add(new MainHero(10, 1, 10, 5));
gameMap.BackMap[0].Add(new Coin(1));
gameMap.BackMap[0].Add(new Ground(GroundType.ground));
gameMap.BackMap[0].Add(new Enemy(1));

gameMap.BackMap.Add(new List<dynamic>());

gameMap.BackMap[1].Add(new Ground(GroundType.ground));
gameMap.BackMap[1].Add(new Ground(GroundType.ground));
gameMap.BackMap[1].Add(new Coin(1));
gameMap.BackMap[1].Add(new Ground(GroundType.ground));
gameMap.BackMap[1].Add(new Enemy(1));

gameMap.BackMap.Add(new List<dynamic>());

gameMap.BackMap[2].Add(new Ground(GroundType.ground));
gameMap.BackMap[2].Add(new Enemy(1));
gameMap.BackMap[2].Add(new Ground(GroundType.ground));
gameMap.BackMap[2].Add(new Ground(GroundType.ground));
gameMap.BackMap[2].Add(new Coin(1));

VisualMap visualMap = new(gameMap);
visualMap.InitiateVisualMap();


