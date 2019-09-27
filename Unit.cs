using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_Part_1
{
    abstract class Unit
    {
        protected int xPosition;
        protected int yPosition;
        protected int hp;
        protected int attack;
        protected int range;
        protected string faction;
        protected string symbol;
        protected string name;
        protected int maxHp;
        protected bool attacking;

        public int XPosition { get => xPosition; set => xPosition = value; }
        public int YPosition { get => yPosition; set => yPosition = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Range { get => range; set => xPosition = value; }
        public string Faction { get => faction; set => faction = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string Name { get => name; set => name = value; }
        public bool Attacking { get => attacking; set => attacking = value; }

        public Unit(int Xposition, int Yposition, string Faction, string Symbol, string Name)
        {

        }

        public abstract Unit GetClosestUnit(Unit[] units);

        public abstract bool InRange(Unit enemy);

        public abstract void MoveToEnemy(Unit enemy);

        public abstract int AttackPhase();

        public abstract void IsDead();

        public abstract void RunAway();

        
    
    }



}
