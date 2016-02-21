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
		public int _factoryBuildCostBase_gold;
		public int _factoryUnitProfit_gold;
		public int _factoryUnitProfit_wood;
		public int _factoryUnitProfit_stone;
		public int _factoryUnitProfit_metal;
		public int _factoryUnitCost_gold;
		public int _factoryUnitCost_wood;
		public int _factoryUnitCost_stone;
		public int _factoryUnitCost_metal;
		public int _unitCapacity;
		public int _unitsPerMinute;
		public int _upgradeCapacityCostBase_gold;
		public int _upgradeSpeedCostBase_gold;
		public int _upgradeQualityCostBase_gold;
		public int _maxOfThisType;
		public int _maxUpgradesEach;
		public FactoryDBRow(string __ID, string __name, string __description, string __factoryBuildCostBase_gold, string __factoryUnitProfit_gold, string __factoryUnitProfit_wood, string __factoryUnitProfit_stone, string __factoryUnitProfit_metal, string __factoryUnitCost_gold, string __factoryUnitCost_wood, string __factoryUnitCost_stone, string __factoryUnitCost_metal, string __unitCapacity, string __unitsPerMinute, string __upgradeCapacityCostBase_gold, string __upgradeSpeedCostBase_gold, string __upgradeQualityCostBase_gold, string __maxOfThisType, string __maxUpgradesEach) 
		{
			_name = __name.Trim();
			_description = __description.Trim();
			{
			int res;
				if(int.TryParse(__factoryBuildCostBase_gold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryBuildCostBase_gold = res;
				else
					Debug.LogError("Failed To Convert _factoryBuildCostBase_gold string: "+ __factoryBuildCostBase_gold +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitProfit_gold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitProfit_gold = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitProfit_gold string: "+ __factoryUnitProfit_gold +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitProfit_wood, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitProfit_wood = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitProfit_wood string: "+ __factoryUnitProfit_wood +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitProfit_stone, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitProfit_stone = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitProfit_stone string: "+ __factoryUnitProfit_stone +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitProfit_metal, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitProfit_metal = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitProfit_metal string: "+ __factoryUnitProfit_metal +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitCost_gold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitCost_gold = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitCost_gold string: "+ __factoryUnitCost_gold +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitCost_wood, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitCost_wood = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitCost_wood string: "+ __factoryUnitCost_wood +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitCost_stone, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitCost_stone = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitCost_stone string: "+ __factoryUnitCost_stone +" to int");
			}
			{
			int res;
				if(int.TryParse(__factoryUnitCost_metal, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_factoryUnitCost_metal = res;
				else
					Debug.LogError("Failed To Convert _factoryUnitCost_metal string: "+ __factoryUnitCost_metal +" to int");
			}
			{
			int res;
				if(int.TryParse(__unitCapacity, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_unitCapacity = res;
				else
					Debug.LogError("Failed To Convert _unitCapacity string: "+ __unitCapacity +" to int");
			}
			{
			int res;
				if(int.TryParse(__unitsPerMinute, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_unitsPerMinute = res;
				else
					Debug.LogError("Failed To Convert _unitsPerMinute string: "+ __unitsPerMinute +" to int");
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
				if(int.TryParse(__upgradeQualityCostBase_gold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_upgradeQualityCostBase_gold = res;
				else
					Debug.LogError("Failed To Convert _upgradeQualityCostBase_gold string: "+ __upgradeQualityCostBase_gold +" to int");
			}
			{
			int res;
				if(int.TryParse(__maxOfThisType, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_maxOfThisType = res;
				else
					Debug.LogError("Failed To Convert _maxOfThisType string: "+ __maxOfThisType +" to int");
			}
			{
			int res;
				if(int.TryParse(__maxUpgradesEach, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_maxUpgradesEach = res;
				else
					Debug.LogError("Failed To Convert _maxUpgradesEach string: "+ __maxUpgradesEach +" to int");
			}
		}

		public int Length { get { return 18; } }

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
					ret = _factoryBuildCostBase_gold.ToString();
					break;
				case 3:
					ret = _factoryUnitProfit_gold.ToString();
					break;
				case 4:
					ret = _factoryUnitProfit_wood.ToString();
					break;
				case 5:
					ret = _factoryUnitProfit_stone.ToString();
					break;
				case 6:
					ret = _factoryUnitProfit_metal.ToString();
					break;
				case 7:
					ret = _factoryUnitCost_gold.ToString();
					break;
				case 8:
					ret = _factoryUnitCost_wood.ToString();
					break;
				case 9:
					ret = _factoryUnitCost_stone.ToString();
					break;
				case 10:
					ret = _factoryUnitCost_metal.ToString();
					break;
				case 11:
					ret = _unitCapacity.ToString();
					break;
				case 12:
					ret = _unitsPerMinute.ToString();
					break;
				case 13:
					ret = _upgradeCapacityCostBase_gold.ToString();
					break;
				case 14:
					ret = _upgradeSpeedCostBase_gold.ToString();
					break;
				case 15:
					ret = _upgradeQualityCostBase_gold.ToString();
					break;
				case 16:
					ret = _maxOfThisType.ToString();
					break;
				case 17:
					ret = _maxUpgradesEach.ToString();
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
				case "factoryBuildCostBase_gold":
					ret = _factoryBuildCostBase_gold.ToString();
					break;
				case "factoryUnitProfit_gold":
					ret = _factoryUnitProfit_gold.ToString();
					break;
				case "factoryUnitProfit_wood":
					ret = _factoryUnitProfit_wood.ToString();
					break;
				case "factoryUnitProfit_stone":
					ret = _factoryUnitProfit_stone.ToString();
					break;
				case "factoryUnitProfit_metal":
					ret = _factoryUnitProfit_metal.ToString();
					break;
				case "factoryUnitCost_gold":
					ret = _factoryUnitCost_gold.ToString();
					break;
				case "factoryUnitCost_wood":
					ret = _factoryUnitCost_wood.ToString();
					break;
				case "factoryUnitCost_stone":
					ret = _factoryUnitCost_stone.ToString();
					break;
				case "factoryUnitCost_metal":
					ret = _factoryUnitCost_metal.ToString();
					break;
				case "unitCapacity":
					ret = _unitCapacity.ToString();
					break;
				case "unitsPerMinute":
					ret = _unitsPerMinute.ToString();
					break;
				case "upgradeCapacityCostBase_gold":
					ret = _upgradeCapacityCostBase_gold.ToString();
					break;
				case "upgradeSpeedCostBase_gold":
					ret = _upgradeSpeedCostBase_gold.ToString();
					break;
				case "upgradeQualityCostBase_gold":
					ret = _upgradeQualityCostBase_gold.ToString();
					break;
				case "maxOfThisType":
					ret = _maxOfThisType.ToString();
					break;
				case "maxUpgradesEach":
					ret = _maxUpgradesEach.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "name" + " : " + _name.ToString() + "} ";
			ret += "{" + "description" + " : " + _description.ToString() + "} ";
			ret += "{" + "factoryBuildCostBase_gold" + " : " + _factoryBuildCostBase_gold.ToString() + "} ";
			ret += "{" + "factoryUnitProfit_gold" + " : " + _factoryUnitProfit_gold.ToString() + "} ";
			ret += "{" + "factoryUnitProfit_wood" + " : " + _factoryUnitProfit_wood.ToString() + "} ";
			ret += "{" + "factoryUnitProfit_stone" + " : " + _factoryUnitProfit_stone.ToString() + "} ";
			ret += "{" + "factoryUnitProfit_metal" + " : " + _factoryUnitProfit_metal.ToString() + "} ";
			ret += "{" + "factoryUnitCost_gold" + " : " + _factoryUnitCost_gold.ToString() + "} ";
			ret += "{" + "factoryUnitCost_wood" + " : " + _factoryUnitCost_wood.ToString() + "} ";
			ret += "{" + "factoryUnitCost_stone" + " : " + _factoryUnitCost_stone.ToString() + "} ";
			ret += "{" + "factoryUnitCost_metal" + " : " + _factoryUnitCost_metal.ToString() + "} ";
			ret += "{" + "unitCapacity" + " : " + _unitCapacity.ToString() + "} ";
			ret += "{" + "unitsPerMinute" + " : " + _unitsPerMinute.ToString() + "} ";
			ret += "{" + "upgradeCapacityCostBase_gold" + " : " + _upgradeCapacityCostBase_gold.ToString() + "} ";
			ret += "{" + "upgradeSpeedCostBase_gold" + " : " + _upgradeSpeedCostBase_gold.ToString() + "} ";
			ret += "{" + "upgradeQualityCostBase_gold" + " : " + _upgradeQualityCostBase_gold.ToString() + "} ";
			ret += "{" + "maxOfThisType" + " : " + _maxOfThisType.ToString() + "} ";
			ret += "{" + "maxUpgradesEach" + " : " + _maxUpgradesEach.ToString() + "} ";
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
			Rows.Add( new FactoryDBRow("LumberYard", "Lumber Yard", "Chops down Trees", "5", "0", "1", "0", "0", "0", "0", "0", "0", "10", "20", "5", "5", "5", "5", "5"));
			Rows.Add( new FactoryDBRow("Quarry", "Quarry", "Excavates Stone", "10", "0", "1", "0", "0", "0", "0", "0", "0", "10", "20", "5", "5", "5", "5", "5"));
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
