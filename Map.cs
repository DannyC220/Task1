using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_Part_1
{
    class Map
    {
        public string[,] GameMap = new string[20, 20];
        public Unit[] units = new Unit[10];
        string[] Names = new string[] { "Tashina", "Keren", "Elane", "Sharonda", "Darrick", "Myrtice", "Tawana", "Irvin", "Nadene", "Phoebe", "Hilaria", "Shera", "Monty", "Jolyn", "Minh", "Solomon", "Jami", "Shalanda", "Kristina", "Su " };

        Random rnd = new Random();

        public Map()
        {

        }

        public void GetMap()
        {
            for (int y = 0; y < 20; y++)
            {
                for(int x = 0; x < 20; x++)
                {
                    GameMap[y, x] = " ";
                }
            }
        }

        public void PopulateMap()
        {
            SpawnUnits();

            for(int k = 0; k < units.Length; k++)
            {
                Console.WriteLine(units[k].ToString());
            }
            
        }

        public void SpawnUnits()
        {
            for (int k = 0; k < units.Length; k++)
            {
                int Type;
                int Faction;
                int name = rnd.Next(0, Names.Length);

                string myFaction = "";
                string mySymbol = "";
                int x = rnd.Next(1, 20);
                int y = rnd.Next(1, 20);

                Type = rnd.Next(1, 3);

                switch (Type)
                {
                    case 1:
                        Faction = rnd.Next(1, 3);

                        switch (Faction)
                        {
                            case 1:
                                myFaction = "Gold Team";
                                mySymbol = "M";
                                break;
                            case 2:
                                myFaction = "Silver Team";
                                mySymbol = "m";
                                break;
                        }
                        units[k] = new MeleeUnit(x, y, myFaction, mySymbol, Names[name]);
                        break;

                    case 2:
                        Faction = rnd.Next(1, 3);

                        switch (Faction)
                        {
                            case 1:
                                myFaction = "Gold Team";
                                mySymbol = "R";
                                break;
                            case 2:
                                myFaction = "Silver Team";
                                mySymbol = "r";
                                break;
                        }
                        units[k] = new MeleeUnit(x, y, myFaction, mySymbol, Names[name]);
                        break;
                }
                GameMap[units[k].YPosition, units[k].XPosition] = units[k].Symbol;            
            }
        }
    }
}
