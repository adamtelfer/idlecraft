using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google2u;

namespace Assets
{
    public class FactoryConfig
    {
        public string factoryID;

        public string name;
        public string description;

        public Economy baseBuildCost;

        public Economy baseProfit;
        public Economy baseUnitCost;

        public int baseUnitCapacity;
        public int baseUnitsPerMinute;

        public int stepCapacity;
        public int stepQuantity;
        public int stepSpeed;

        public int maxCapacityUpgrades;
        public int maxQuantityUpgrades;
        public int maxSpeedUpgrades;

        public Economy upgradeCapacityBase;
        public Economy upgradeSpeedBase;
        public Economy upgradeQualityBase;

        public int maxOfThisType;

        public FactoryConfig(string rowID, FactoryDBRow configRow)
        {
            factoryID = rowID;
            name = configRow._name;
            description = configRow._description;

            baseBuildCost = new Economy(configRow._factoryBuildCostBase);

            // profit type
            baseProfit = new Economy((Economy.EconomyType)configRow._factoryUnitProfit_EconomyType, configRow._startQuantity);

            // cost types
            baseUnitCost = new Economy((Economy.EconomyType)configRow._factoryUnitCost_EconomyType_1, configRow._factoryUnitCost_Amount_1);

            // base
            baseUnitCapacity = configRow._startCapacity;
            baseUnitsPerMinute = configRow._startProdPerMinute;

            // step
            stepQuantity = configRow._upgradeQuantityStep;
            stepSpeed = configRow._upgradeSpeedStep;
            stepCapacity = configRow._upgradeCapacityStep;

            // upgrade cost
            upgradeCapacityBase = new Economy(configRow._upgradeCapacityCostBase_gold);
            upgradeSpeedBase = new Economy(configRow._upgradeSpeedCostBase_gold);
            upgradeQualityBase = new Economy(configRow._upgradeQuantityCostBase_gold);

            // max upgrades
            maxQuantityUpgrades = configRow._maxQuantityUpgrades;
            maxSpeedUpgrades = configRow._maxSpeedUpgrades;
            maxCapacityUpgrades = configRow._maxCapacityUpgrades;

            // max of this type of factory
            maxOfThisType = configRow._maxOfThisTypeOfFactory;
        }
    }
}
