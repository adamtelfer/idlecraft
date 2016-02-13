using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class Factory
    {
        public String name;

        public Economy unitProfit;
        public Economy cappedProfit;
        public Economy currentProfit;

        public Economy unitCost;
        public Economy collectedUnits;

        public enum FactoryStatus
        {
            WORKING,
            FULL,
            HALTED
        };

        public float timeToProduceUnit;

        private FactoryStatus _status;
        public FactoryStatus status
        {
            get { return _status; }
        }

        private float _time;

        public Factory()
        {
            name = "New Factory";

            unitProfit = new Economy();
            unitProfit.food = 1;
            cappedProfit = new Economy();
            cappedProfit.food = 10;
            currentProfit = new Economy();
            unitCost = new Economy();

            timeToProduceUnit = 5f;
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
    }
}
