using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class Economy
    {
        public enum EconomyType
        {
            FOOD, WOOD, STONE, METAL
        };

        public int food;
        public int wood;
        public int stone;
        public int metal;

        public Economy()
        {
            food = 0;
            wood = 0;
            stone = 0;
            metal = 0;
        }

        public int getValueForType (EconomyType type)
        {
            switch (type)
            {
                case EconomyType.FOOD:
                    return food;
                case EconomyType.WOOD:
                    return wood;
                case EconomyType.STONE:
                    return stone;
                case EconomyType.METAL:
                    return metal;          
            }
            return 0;
        }

        public static Economy operator +(Economy e1, Economy e2)
        {
            Economy n = new Economy();
            n.food = e1.food + e2.food;
            n.wood = e1.wood + e2.wood;
            n.stone = e1.stone + e2.stone;
            n.metal = e1.metal + e2.metal;
            return n;
        }

        public void capEconomy (Economy capEconomy)
        {
            if (food > capEconomy.food) { food = capEconomy.food; }
            if (wood > capEconomy.wood) { wood = capEconomy.wood; }
            if (stone > capEconomy.stone) { stone = capEconomy.stone; }
            if (metal > capEconomy.metal) { metal = capEconomy.metal; }
        }

        public static bool operator ==(Economy e1, Economy e2)
        {
            return (e1.food == e2.food &&
                e1.wood == e2.wood &&
                e1.stone == e2.stone &&
                e1.metal == e2.metal);
        }

        public static bool operator !=(Economy e1, Economy e2)
        {
            return (e1.food != e2.food &&
                e1.wood != e2.wood &&
                e1.stone != e2.stone &&
                e1.metal != e2.metal);
        }

        public int size()
        {
            return food + wood + stone + metal;
        }

    }
}
