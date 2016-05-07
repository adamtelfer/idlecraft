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
	public class ConfigDBRow : IGoogle2uRow
	{
		public int _initial_gold;
		public float _buildingCostExponent;
		public float _upgradeCostExponent;
		public float _quantityCostExponent;
		public ConfigDBRow(string __ID, string __initial_gold, string __buildingCostExponent, string __upgradeCostExponent, string __quantityCostExponent) 
		{
			{
			int res;
				if(int.TryParse(__initial_gold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_initial_gold = res;
				else
					Debug.LogError("Failed To Convert _initial_gold string: "+ __initial_gold +" to int");
			}
			{
			float res;
				if(float.TryParse(__buildingCostExponent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_buildingCostExponent = res;
				else
					Debug.LogError("Failed To Convert _buildingCostExponent string: "+ __buildingCostExponent +" to float");
			}
			{
			float res;
				if(float.TryParse(__upgradeCostExponent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_upgradeCostExponent = res;
				else
					Debug.LogError("Failed To Convert _upgradeCostExponent string: "+ __upgradeCostExponent +" to float");
			}
			{
			float res;
				if(float.TryParse(__quantityCostExponent, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_quantityCostExponent = res;
				else
					Debug.LogError("Failed To Convert _quantityCostExponent string: "+ __quantityCostExponent +" to float");
			}
		}

		public int Length { get { return 4; } }

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
					ret = _initial_gold.ToString();
					break;
				case 1:
					ret = _buildingCostExponent.ToString();
					break;
				case 2:
					ret = _upgradeCostExponent.ToString();
					break;
				case 3:
					ret = _quantityCostExponent.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "initial_gold":
					ret = _initial_gold.ToString();
					break;
				case "buildingCostExponent":
					ret = _buildingCostExponent.ToString();
					break;
				case "upgradeCostExponent":
					ret = _upgradeCostExponent.ToString();
					break;
				case "quantityCostExponent":
					ret = _quantityCostExponent.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "initial_gold" + " : " + _initial_gold.ToString() + "} ";
			ret += "{" + "buildingCostExponent" + " : " + _buildingCostExponent.ToString() + "} ";
			ret += "{" + "upgradeCostExponent" + " : " + _upgradeCostExponent.ToString() + "} ";
			ret += "{" + "quantityCostExponent" + " : " + _quantityCostExponent.ToString() + "} ";
			return ret;
		}
	}
	public sealed class ConfigDB : IGoogle2uDB
	{
		public enum rowIds {
			Default, Ver1, Ver2, Ver3
		};
		public string [] rowNames = {
			"Default", "Ver1", "Ver2", "Ver3"
		};
		public System.Collections.Generic.List<ConfigDBRow> Rows = new System.Collections.Generic.List<ConfigDBRow>();

		public static ConfigDB Instance
		{
			get { return NestedConfigDB.instance; }
		}

		private class NestedConfigDB
		{
			static NestedConfigDB() { }
			internal static readonly ConfigDB instance = new ConfigDB();
		}

		private ConfigDB()
		{
			Rows.Add( new ConfigDBRow("Default", "75", "2", "1.5", "2"));
			Rows.Add( new ConfigDBRow("Ver1", "75", "2", "1.5", "2"));
			Rows.Add( new ConfigDBRow("Ver2", "75", "2", "1.5", "2"));
			Rows.Add( new ConfigDBRow("Ver3", "75", "2", "1.5", "2"));
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
		public ConfigDBRow GetRow(rowIds in_RowID)
		{
			ConfigDBRow ret = null;
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
		public ConfigDBRow GetRow(string in_RowString)
		{
			ConfigDBRow ret = null;
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
