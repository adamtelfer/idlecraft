using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Text;
using Google2u;

namespace Assets
{
    public class Economy
    {
        public enum EconomyType
        {
            GOLD, WOOD, STONE, METAL
        };

        public int gold;
        public int wood;
        public int stone;
        public int metal;

        public Economy()
        {
            gold = 0;
            wood = 0;
            stone = 0;
            metal = 0;
        }

        public Economy(Economy e)
        {
            gold = e.gold;
            wood = e.wood;
            stone = e.stone;
            metal = e.metal;
        }

        public Economy(int pgold, int pwood = 0, int pstone = 0, int pmetal = 0)
        {
            gold = pgold;
            wood = pwood;
            stone = pstone;
            metal = pmetal;
        }

        public Economy (EconomyType economyType, int amount)
        {
            AddForEconomyType(economyType, amount);
        }

        public bool AddForEconomyType (EconomyType economyType, int amount)
        {
            switch (economyType)
            {
                case EconomyType.GOLD:
                    gold += amount; return true;
                case EconomyType.WOOD:
                    wood += amount; return true;
                case EconomyType.STONE:
                    stone += amount; return true;
                case EconomyType.METAL:
                    metal += amount; return true;
                default:
                    return false;
            }
        }

        public static EconomyType getTypeForConfig (EconomyDBRow config)
        {
            return (EconomyType)(Int32.Parse(config._ID));
        }

        public int getValueForType (EconomyDBRow config)
        {
            return getValueForType(getTypeForConfig(config));
        }

        public int getValueForType (EconomyType type)
        {
            switch (type)
            {
                case EconomyType.GOLD:
                    return gold;
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
            n.gold = e1.gold + e2.gold;
            n.wood = e1.wood + e2.wood;
            n.stone = e1.stone + e2.stone;
            n.metal = e1.metal + e2.metal;
            return n;
        }

        public static Economy operator *(Economy e1, int val2)
        {
            Economy n = new Economy();
            n.gold = e1.gold * val2;
            n.wood = e1.wood * val2;
            n.stone = e1.stone * val2;
            n.metal = e1.metal * val2;
            return n;
        }

        public void capEconomy (Economy capEconomy)
        {
            if (gold > capEconomy.gold) { gold = capEconomy.gold; }
            if (wood > capEconomy.wood) { wood = capEconomy.wood; }
            if (stone > capEconomy.stone) { stone = capEconomy.stone; }
            if (metal > capEconomy.metal) { metal = capEconomy.metal; }
        }

        public static bool operator ==(Economy e1, Economy e2)
        {
            return (e1.gold == e2.gold &&
                e1.wood == e2.wood &&
                e1.stone == e2.stone &&
                e1.metal == e2.metal);
        }

        public static bool operator !=(Economy e1, Economy e2)
        {
            return (e1.gold != e2.gold &&
                e1.wood != e2.wood &&
                e1.stone != e2.stone &&
                e1.metal != e2.metal);
        }

        public int size()
        {
            return gold + wood + stone + metal;
        }

        public bool canPurchase(Economy e)
        {
            return (gold >= e.gold &&
                wood >= e.wood &&
                stone >= e.stone &&
                metal >= e.metal);
        }

        public void purchase(Economy e)
        {
            if (canPurchase(e))
            {
                gold -= e.gold;
                wood -= e.wood;
                stone -= e.stone;
                metal -= e.metal;
            }
        }

        public Economy applyGrowthCurve(int purchaseLevel, float baseExponent)
        {
            Economy e = new Economy();
            e.gold = (int)(gold * Mathf.Pow(baseExponent, purchaseLevel));
            e.wood = (int)(wood * Mathf.Pow(baseExponent, purchaseLevel));
            e.stone = (int)(stone * Mathf.Pow(baseExponent, purchaseLevel));
            e.metal = (int)(metal * Mathf.Pow(baseExponent, purchaseLevel));
            return e;
        }

        public string toReadableText()
        {
            string result = "";
            if (gold > 0) { result += string.Format("{0}xGOLD ", gold);  }
            if (wood > 0) { result += string.Format("{0}xWOOD ", wood);  }
            if (stone > 0) { result += string.Format("{0}xSTONE ", stone); }
            if (metal > 0) { result += string.Format("{0}xMETAL ", metal); }
            return result;
        }

    }
}
