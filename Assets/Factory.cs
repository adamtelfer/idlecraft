using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class Factory
    {
        public FactoryConfig config;

        //TODO: Factory is not loading Config Properly
        public Economy unitProfit;
        public Economy cappedProfit;
        public Economy currentProfit;

        public Economy unitCost;
        public Economy collectedUnits;

        public int unitsPerMinute;
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

            unitProfit = new Economy(f.baseProfit);
            cappedProfit = new Economy(f.baseProfit) * f.baseUnitCapacity;
            currentProfit = new Economy();
            unitCost = new Economy(f.baseUnitCost);

            timeToProduceUnit = 60f / ((float)unitsPerMinute);

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
            cappedProfit = cappedProfit + (unitProfit + unitProfit + unitProfit + unitProfit);
        }

        public void UpgradeProductionSpeed()
        {
            unitsPerMinute += 5;
            timeToProduceUnit = 60f / ((float)unitsPerMinute);
            _time = timeToProduceUnit;
        }
    }
}
