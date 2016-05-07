//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class FactoryDBRow : IGoogle2uRow
	{
		public string _name;
		public string _description;
		public int _factoryBuildCostBase;
		public int _factoryUnitProfit_EconomyType;
		public int _factoryUnitCost_EconomyType_1;
		public int _factoryUnitCost_Amount_1;
		public int _startCapacity;
		public int _startProdPerMinute;
		public int _startQuantity;
		public int _upgradeCapacityStep;
		public int _upgradeSpeedStep;
		public int _upgradeQuantityStep;
		public int _upgradeCapacityCostBase_gold;
		public int _upgradeSpeedCostBase_gold;
		public int _upgradeQuantityCostBase_gold;
		public int _maxCapacityUpgrades;
		public int _maxSpeedUpgrades;
		public int _maxQuantityUpgrades;
		public int _maxOfThisTypeOfFactory;
		public FactoryDBRow(string __ID, string __name, string __description, string __factoryBuildCostBase, string __factoryUnitProfit_EconomyType, string __factoryUnitCost_EconomyType_1, string __factoryUnitCost_Amount_1, string __startCapacity, string __startProdPerMinute, string __startQuantity, string __upgradeCapacityStep, string __upgradeSpeedStep, string __upgradeQuantityStep, string __upgradeCapacityCostBase_gold, string __upgradeSpeedCostBase_gold, string __upgradeQuantityCostBase_gold, string __maxCapacityUpgrades, string __maxSpeedUpgrades, string __maxQuantityUpgrades, string __maxOfThisTypeOfFactory) 
		{
			_name = __name.Trim();
			_description = __description.Trim();
			{
			int res;
				if(int.TryParse(__factoryBuildCostBase, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryBuildCostBase = res;
				else
					Debug.LogError("Failed To Convert _factoryBuildCostBase string: "+ __factoryBuildCostBase +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitProfit_EconomyType, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitProfit_EconomyType = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitProfit_EconomyType string: "+ __factoryUnitProfit_EconomyType +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitCost_EconomyType_1, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitCost_EconomyType_1 = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitCost_EconomyType_1 string: "+ __factoryUnitCost_EconomyType_1 +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitCost_Amount_1, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitCost_Amount_1 = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitCost_Amount_1 string: "+ __factoryUnitCost_Amount_1 +" to int");
			}
			{
			int res;
				if(int.TryParse(__startCapacity, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_startCapacity = res;
				else
					Debug.LogError("Failed To Convert _startCapacity string: "+ __startCapacity +" to int");
			}
			{
			int res;
				if(int.TryParse(__startProdPerMinute, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_startProdPerMinute = res;
				else
					Debug.LogError("Failed To Convert _startProdPerMinute string: "+ __startProdPerMinute +" to int");
			}
			{
			int res;
				if(int.TryParse(__startQuantity, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_startQuantity = res;
				else
					Debug.LogError("Failed To Convert _startQuantity string: "+ __startQuantity +" to int");
			}
			{
			int res;
				if(int.TryParse(__upgradeCapacityStep, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_upgradeCapacityStep = res;
				else
					Debug.LogError("Failed To Convert _upgradeCapacityStep string: "+ __upgradeCapacityStep +" to int");
			}
			{
			int res;
				if(int.TryParse(__upgradeSpeedStep, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_upgradeSpeedStep = res;
				else
					Debug.LogError("Failed To Convert _upgradeSpeedStep string: "+ __upgradeSpeedStep +" to int");
			}
			{
			int res;
				if(int.TryParse(__upgradeQuantityStep, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_upgradeQuantityStep = res;
				else
					Debug.LogError("Failed To Convert _upgradeQuantityStep string: "+ __upgradeQuantityStep +" to int");
			}
			{
			int res;
				if(int.TryParse(__upgradeCapacityCostBase_gold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_upgradeCapacityCostBase_gold = res;
				else
					Debug.LogError("Failed To Convert _upgradeCapacityCostBase_gold string: "+ __upgradeCapacityCostBase_gold +" to int");
			}
			{
			int res;
				if(int.TryParse(__upgradeSpeedCostBase_gold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_upgradeSpeedCostBase_gold = res;
				else
					Debug.LogError("Failed To Convert _upgradeSpeedCostBase_gold string: "+ __upgradeSpeedCostBase_gold +" to int");
			}
			{
			int res;
				if(int.TryParse(__upgradeQuantityCostBase_gold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_upgradeQuantityCostBase_gold = res;
				else
					Debug.LogError("Failed To Convert _upgradeQuantityCostBase_gold string: "+ __upgradeQuantityCostBase_gold +" to int");
			}
			{
			int res;
				if(int.TryParse(__maxCapacityUpgrades, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_maxCapacityUpgrades = res;
				else
					Debug.LogError("Failed To Convert _maxCapacityUpgrades string: "+ __maxCapacityUpgrades +" to int");
			}
			{
			int res;
				if(int.TryParse(__maxSpeedUpgrades, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_maxSpeedUpgrades = res;
				else
					Debug.LogError("Failed To Convert _maxSpeedUpgrades string: "+ __maxSpeedUpgrades +" to int");
			}
			{
			int res;
				if(int.TryParse(__maxQuantityUpgrades, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_maxQuantityUpgrades = res;
				else
					Debug.LogError("Failed To Convert _maxQuantityUpgrades string: "+ __maxQuantityUpgrades +" to int");
			}
			{
			int res;
				if(int.TryParse(__maxOfThisTypeOfFactory, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_maxOfThisTypeOfFactory = res;
				else
					Debug.LogError("Failed To Convert _maxOfThisTypeOfFactory string: "+ __maxOfThisTypeOfFactory +" to int");
			}
		}

		public int Length { get { return 19; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _name.ToString();
					break;
				case 1:
					ret = _description.ToString();
					break;
				case 2:
					ret = _factoryBuildCostBase.ToString();
					break;
				case 3:
					ret = _factoryUnitProfit_EconomyType.ToString();
					break;
				case 4:
					ret = _factoryUnitCost_EconomyType_1.ToString();
					break;
				case 5:
					ret = _factoryUnitCost_Amount_1.ToString();
					break;
				case 6:
					ret = _startCapacity.ToString();
					break;
				case 7:
					ret = _startProdPerMinute.ToString();
					break;
				case 8:
					ret = _startQuantity.ToString();
					break;
				case 9:
					ret = _upgradeCapacityStep.ToString();
					break;
				case 10:
					ret = _upgradeSpeedStep.ToString();
					break;
				case 11:
					ret = _upgradeQuantityStep.ToString();
					break;
				case 12:
					ret = _upgradeCapacityCostBase_gold.ToString();
					break;
				case 13:
					ret = _upgradeSpeedCostBase_gold.ToString();
					break;
				case 14:
					ret = _upgradeQuantityCostBase_gold.ToString();
					break;
				case 15:
					ret = _maxCapacityUpgrades.ToString();
					break;
				case 16:
					ret = _maxSpeedUpgrades.ToString();
					break;
				case 17:
					ret = _maxQuantityUpgrades.ToString();
					break;
				case 18:
					ret = _maxOfThisTypeOfFactory.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "name":
					ret = _name.ToString();
					break;
				case "description":
					ret = _description.ToString();
					break;
				case "factoryBuildCostBase":
					ret = _factoryBuildCostBase.ToString();
					break;
				case "factoryUnitProfit_EconomyType":
					ret = _factoryUnitProfit_EconomyType.ToString();
					break;
				case "factoryUnitCost_EconomyType_1":
					ret = _factoryUnitCost_EconomyType_1.ToString();
					break;
				case "factoryUnitCost_Amount_1":
					ret = _factoryUnitCost_Amount_1.ToString();
					break;
				case "startCapacity":
					ret = _startCapacity.ToString();
					break;
				case "startProdPerMinute":
					ret = _startProdPerMinute.ToString();
					break;
				case "startQuantity":
					ret = _startQuantity.ToString();
					break;
				case "upgradeCapacityStep":
					ret = _upgradeCapacityStep.ToString();
					break;
				case "upgradeSpeedStep":
					ret = _upgradeSpeedStep.ToString();
					break;
				case "upgradeQuantityStep":
					ret = _upgradeQuantityStep.ToString();
					break;
				case "upgradeCapacityCostBase_gold":
					ret = _upgradeCapacityCostBase_gold.ToString();
					break;
				case "upgradeSpeedCostBase_gold":
					ret = _upgradeSpeedCostBase_gold.ToString();
					break;
				case "upgradeQuantityCostBase_gold":
					ret = _upgradeQuantityCostBase_gold.ToString();
					break;
				case "maxCapacityUpgrades":
					ret = _maxCapacityUpgrades.ToString();
					break;
				case "maxSpeedUpgrades":
					ret = _maxSpeedUpgrades.ToString();
					break;
				case "maxQuantityUpgrades":
					ret = _maxQuantityUpgrades.ToString();
					break;
				case "maxOfThisTypeOfFactory":
					ret = _maxOfThisTypeOfFactory.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "name" + " : " + _name.ToString() + "} ";
			ret += "{" + "description" + " : " + _description.ToString() + "} ";
			ret += "{" + "factoryBuildCostBase" + " : " + _factoryBuildCostBase.ToString() + "} ";
			ret += "{" + "factoryUnitProfit_EconomyType" + " : " + _factoryUnitProfit_EconomyType.ToString() + "} ";
			ret += "{" + "factoryUnitCost_EconomyType_1" + " : " + _factoryUnitCost_EconomyType_1.ToString() + "} ";
			ret += "{" + "factoryUnitCost_Amount_1" + " : " + _factoryUnitCost_Amount_1.ToString() + "} ";
			ret += "{" + "startCapacity" + " : " + _startCapacity.ToString() + "} ";
			ret += "{" + "startProdPerMinute" + " : " + _startProdPerMinute.ToString() + "} ";
			ret += "{" + "startQuantity" + " : " + _startQuantity.ToString() + "} ";
			ret += "{" + "upgradeCapacityStep" + " : " + _upgradeCapacityStep.ToString() + "} ";
			ret += "{" + "upgradeSpeedStep" + " : " + _upgradeSpeedStep.ToString() + "} ";
			ret += "{" + "upgradeQuantityStep" + " : " + _upgradeQuantityStep.ToString() + "} ";
			ret += "{" + "upgradeCapacityCostBase_gold" + " : " + _upgradeCapacityCostBase_gold.ToString() + "} ";
			ret += "{" + "upgradeSpeedCostBase_gold" + " : " + _upgradeSpeedCostBase_gold.ToString() + "} ";
			ret += "{" + "upgradeQuantityCostBase_gold" + " : " + _upgradeQuantityCostBase_gold.ToString() + "} ";
			ret += "{" + "maxCapacityUpgrades" + " : " + _maxCapacityUpgrades.ToString() + "} ";
			ret += "{" + "maxSpeedUpgrades" + " : " + _maxSpeedUpgrades.ToString() + "} ";
			ret += "{" + "maxQuantityUpgrades" + " : " + _maxQuantityUpgrades.ToString() + "} ";
			ret += "{" + "maxOfThisTypeOfFactory" + " : " + _maxOfThisTypeOfFactory.ToString() + "} ";
			return ret;
		}
	}
	public sealed class FactoryDB : IGoogle2uDB
	{
		public enum rowIds {
			LumberYard, Quarry
		};
		public string [] rowNames = {
			"LumberYard", "Quarry"
		};
		public System.Collections.Generic.List<FactoryDBRow> Rows = new System.Collections.Generic.List<FactoryDBRow>();

		public static FactoryDB Instance
		{
			get { return NestedFactoryDB.instance; }
		}

		private class NestedFactoryDB
		{
			static NestedFactoryDB() { }
			internal static readonly FactoryDB instance = new FactoryDB();
		}

		private FactoryDB()
		{
			Rows.Add( new FactoryDBRow("LumberYard", "Lumber Yard", "Chops down Trees", "50", "1", "0", "0", "10", "20", "1", "5", "5", "1", "2", "5", "20", "50", "50", "10", "5"));
			Rows.Add( new FactoryDBRow("Quarry", "Quarry", "Excavates Stone", "250", "2", "0", "0", "10", "20", "1", "5", "5", "1", "2", "5", "20", "50", "50", "10", "5"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public FactoryDBRow GetRow(rowIds in_RowID)
		{
			FactoryDBRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public FactoryDBRow GetRow(string in_RowString)
		{
			FactoryDBRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
