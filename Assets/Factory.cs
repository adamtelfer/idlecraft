using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class Factory
    {
        public FactoryConfig config;

        //factory progress state
        public int currentCapacityLevel;
        public int currentSpeedLevel;
        public int currentQuantityLevel;


        public Economy unitProfit // what is produced each time
        {
            get
            {
                return config.baseProfit * ((currentQuantityLevel+1) * config.stepQuantity);
            }
        }

        public Economy cappedProfit
        {
            get
            {
                return (config.baseProfit * config.baseUnitCapacity) + (config.baseProfit * (currentCapacityLevel * config.stepCapacity));
            }
        }

        public Economy currentProfit;
        public Economy unitCost;
        public Economy collectedUnits;

        public int unitsPerMinute
        {
            get
            {
                return config.baseUnitsPerMinute + (currentSpeedLevel * config.stepSpeed);
            }
        }
        private float timeToProduceUnit;

        public enum FactoryStatus
        {
            WORKING,
            FULL,
            HALTED
        };
        private FactoryStatus _status;
        public FactoryStatus status
        {
            get { return _status; }
        }

        private float _time;

        public Factory (FactoryConfig f)
        {
            config = f;
            currentCapacityLevel = 0;
            currentSpeedLevel = 0;
            currentQuantityLevel = 0;

            currentProfit = new Economy();

            timeToProduceUnit = 60f / ((float)this.unitsPerMinute);

            _time = timeToProduceUnit;
            _status = FactoryStatus.WORKING;
        }

        public void tick (float timeDiff)
        {
            if (status == FactoryStatus.WORKING)
            {
                _time -= timeDiff;
                if (_time < 0f)
                {
                    produceUnit();
                    _time = timeToProduceUnit;
                }
            }
        }

        private void produceUnit()
        {
            currentProfit += unitProfit;
            currentProfit.capEconomy(cappedProfit);
            if (currentProfit == cappedProfit)
            {
                _status = FactoryStatus.FULL;
            }
        }

        public float progressToNextUnit()
        {
            float t = Math.Max(0f, _time);
            t = Math.Min(timeToProduceUnit, _time);
            return 1f-(_time / timeToProduceUnit);
        }

        public float progressToCapProfit()
        {
            float capProfitSize = (float)cappedProfit.size();
            float currentSize = (float)currentProfit.size();
            return currentSize / capProfitSize;
        }

        public void Restart()
        {
            _status = FactoryStatus.WORKING;
        }

        private Economy getCostToUpgrade(int currentLevel, int maxLevels, float exponent, Economy baseCost)
        {
            if (currentLevel >= maxLevels)
            {
                return new Economy();
            }
            else
            {
                return baseCost.applyGrowthCurve(currentLevel, exponent);
            }
        }

        public bool CanUpgradeCapacity()
        {
            return (GameState.sharedState.CanPurchase(CostToUpgradeCapacity())) && (currentCapacityLevel < config.maxCapacityUpgrades);
        }

        public bool CanUpgradeProductionSpeed()
        {
            return (GameState.sharedState.CanPurchase(CostToUpgradeProductionSpeed())) && (currentSpeedLevel < config.maxSpeedUpgrades);
        }

        public bool CanUpgradeProductionQuantity()
        {
            return (GameState.sharedState.CanPurchase(CostToUpgradeProductionOutput())) && (currentQuantityLevel < config.maxQuantityUpgrades);
        }

        public Economy CostToUpgradeCapacity()
        {
            return getCostToUpgrade(currentCapacityLevel, config.maxCapacityUpgrades, Config.masterConfig.upgradeCostExponent, config.upgradeCapacityBase);
        }

        public Economy CostToUpgradeProductionSpeed()
        {
            return getCostToUpgrade(currentSpeedLevel, config.maxSpeedUpgrades, Config.masterConfig.upgradeCostExponent, config.upgradeSpeedBase);
        }

        public Economy CostToUpgradeProductionOutput()
        {
            return getCostToUpgrade(currentQuantityLevel, config.maxQuantityUpgrades, Config.masterConfig.productionCostExponent, config.upgradeQualityBase);
        }

        public void UpgradeCapacity()
        {
            if (GameState.sharedState.Purchase(CostToUpgradeCapacity()))
            {
                currentCapacityLevel = Math.Min(currentCapacityLevel + 1, config.maxCapacityUpgrades);
            }
            else
            {
                Debug.LogError("Could Not Purchase Upgrade");
            }
        }

        public void UpgradeProductionSpeed()
        {
            if (GameState.sharedState.Purchase(CostToUpgradeProductionSpeed()))
            {
                currentSpeedLevel = Math.Min(currentSpeedLevel + 1, config.maxSpeedUpgrades);

                timeToProduceUnit = 60f / ((float)this.unitsPerMinute);
                _time = timeToProduceUnit;
            } else
            {
                Debug.LogError("Could Not Purchase Upgrade");
            }
        }

        public void UpgradeProductionOutput()
        {
            if (GameState.sharedState.Purchase(CostToUpgradeProductionOutput()))
            {
                currentQuantityLevel = Math.Min(currentQuantityLevel + 1, config.maxQuantityUpgrades);
            }
            else
            {
                Debug.LogError("Could Not Purchase Upgrade");
            }
        }
    }
}
