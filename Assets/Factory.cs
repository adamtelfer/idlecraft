using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void UpgradeCapacity()
        {
            currentCapacityLevel = Math.Min(currentCapacityLevel + 1, config.maxCapacityUpgrades);
        }

        public void UpgradeProductionSpeed()
        {
            currentSpeedLevel = Math.Min(currentSpeedLevel + 1, config.maxSpeedUpgrades);

            timeToProduceUnit = 60f / ((float)this.unitsPerMinute);
            _time = timeToProduceUnit;
        }

        public void UpgradeProductionOutput()
        {
            currentQuantityLevel = Math.Min(currentQuantityLevel + 1, config.maxQuantityUpgrades);
        }
    }
}
