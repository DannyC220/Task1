using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE_Part_1
{
    class MeleeUnit : Unit
    {
        Random r = new Random();

        public MeleeUnit(int Xposition, int Yposition, string Faction, string Symbol, string Name) : base(Xposition, Yposition, Faction, Symbol, Name)
        {
            this.XPosition = XPosition;
            this.YPosition = Yposition;
            this.hp = 100;
            this.attack = 3;
            this.range = 1;
            this.Faction = Faction;
            this.Symbol = Symbol;
            this.Name = Name;
            this.maxHp = maxHp = 100;
            this.attacking = Attacking = false;
        }

        public override string ToString()
        {
            string[] unitType = GetType().ToString().Split('.');
            string typeOne = unitType[unitType.Length - 1];

            return Faction + "," + Name + "," + typeOne + "," + (XPosition + 1) + "," + (YPosition + 1) + "," + Hp;
        }

        public override Unit GetClosestUnit(Unit[] units)
        {
            int tempDistance = 200;
            int Distance = tempDistance;
            Unit returnedUnit = null;

            for(int k = 0; k < units.Length; k++)
            {
                if(Distance < 0)
                {
                    Distance = Math.Abs(Distance);
                }
                // will attack if a units hp is higher than 0, and if it is not in the same faction as the unit.
                if(units[k] != null && units[k].Hp > 0 && units[k].Faction != this.Faction )
                {
                    Distance = ((this.XPosition - units[k].XPosition) ^ 2 + (this.YPosition - units[k].YPosition) ^ 2) ^ 1 / 2;
                }

                if(Distance < tempDistance)
                {
                    tempDistance = Distance;
                    returnedUnit = units[k];
                }
            }
            return returnedUnit;
        }

        public override void MoveToEnemy(Unit enemy)
        {
            if (enemy != null)
            {
                int distanceX = (enemy.XPosition - XPosition);
                int distanceY = (enemy.YPosition - YPosition);

                if (Math.Abs(distanceX) < Math.Abs(distanceY))
                {
                    if (distanceX < 0)
                     XPosition--;
                        else if (distanceX > 0)
                            XPosition++;
                }
                else if (Math.Abs(distanceY) < Math.Abs(distanceX))
                {
                    if (distanceY < 0)
                        YPosition--;
                    else if (distanceY > 0)
                        YPosition++;
                }
            }
        }

        public override bool InRange(Unit enemy)
        {
            int distance = 300;

            if(enemy != null)
            {
                distance = ((XPosition - enemy.XPosition) ^ 2 + (YPosition - enemy.YPosition) ^ 2) ^ 1 / 2;  // Range calculations
            }
            if (distance <= this.range)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        public override int AttackPhase()
        {
            return this.Attack;
        }

        public override void RunAway() // if 1 is selected move up, if 2 is selected move right, if 3 is selected move left and if 4 is selected move down
        {
            bool valid = false;
            int move = 0;

            while (valid == false)
            {
                move = r.Next(1, 5);
                if (YPosition == 0 && move == 1)
                    valid = false;
                else if (XPosition == 19 && move == 2)
                    valid = false;
                else if (YPosition == 19 && move == 3)
                    valid = false;
                else if (XPosition == 0 && move == 4)
                    valid = false;
                else
                    valid = true;

            }

            switch (move)
            {
                case 1:
                    YPosition--;
                    break;
                case 2:
                    XPosition++;
                    break;
                case 3:
                    YPosition++;
                    break;
                case 4:
                    XPosition--;
                    break;
            }



        }

        public override void IsDead()
        {

        }








    }
}
