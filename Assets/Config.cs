using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;
using Google2u;

namespace Assets
{
    class Config
    {
        public static Config masterConfig;

        public Economy initialEconomy;

        public Dictionary<string,FactoryConfig> factoryTypes;

        public float growthExponent;

        public Config ()
        {
            masterConfig = this;
            ConfigDBRow row = ConfigDB.Instance.GetRow("Default");

            initialEconomy = new Economy();
            initialEconomy.gold = row._initial_gold;

            growthExponent = row._costExponent;

            factoryTypes = new Dictionary<string,FactoryConfig>();
            // Add from FactoryDB from Google:
            foreach (string key in FactoryDB.Instance.rowNames)
            {
                FactoryDBRow frow = FactoryDB.Instance.GetRow(key);
                FactoryConfig fconfig = new FactoryConfig(key,frow);
                factoryTypes.Add(key,fconfig);
            }
        }
    }
}
