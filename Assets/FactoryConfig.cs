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

        public Economy upgradeCapacityBase;
        public Economy upgradeSpeedBase;
        public Economy upgradeQualityBase;

        public int maxOfThisType;
        public int maxUpgradesEach;

        public FactoryConfig(string rowID, FactoryDBRow configRow)
        {
            factoryID = rowID;
            name = configRow._name;
            description = configRow._description;
            baseBuildCost = new Economy(configRow._factoryBuildCostBase_gold);
            baseProfit = new Economy(configRow._factoryUnitProfit_gold, configRow._factoryUnitProfit_wood, configRow._factoryUnitProfit_stone, configRow._factoryUnitProfit_metal);
            baseUnitCost = new Economy(configRow._factoryUnitCost_gold, configRow._factoryUnitCost_wood, configRow._factoryUnitCost_stone, configRow._factoryUnitCost_metal);

            baseUnitCapacity = configRow._unitCapacity;
            baseUnitsPerMinute = configRow._unitsPerMinute;
            upgradeCapacityBase = new Economy(configRow._upgradeCapacityCostBase_gold);
            upgradeSpeedBase = new Economy(configRow._upgradeSpeedCostBase_gold);
            upgradeQualityBase = new Economy(configRow._upgradeQualityCostBase_gold);

            maxOfThisType = configRow._maxOfThisType;
            maxUpgradesEach = configRow._maxUpgradesEach;
        }
    }
}
