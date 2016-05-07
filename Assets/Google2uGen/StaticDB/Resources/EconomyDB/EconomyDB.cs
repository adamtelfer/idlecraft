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
	public class EconomyDBRow : IGoogle2uRow
	{
		public string _longname;
		public int _minMarketValue;
		public int _maxMarketValue;
		public EconomyDBRow(string __ID, string __longname, string __minMarketValue, string __maxMarketValue) 
		{
			_longname = __longname.Trim();
			{
			int res;
				if(int.TryParse(__minMarketValue, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_minMarketValue = res;
				else
					Debug.LogError("Failed To Convert _minMarketValue string: "+ __minMarketValue +" to int");
			}
			{
			int res;
				if(int.TryParse(__maxMarketValue, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_maxMarketValue = res;
				else
					Debug.LogError("Failed To Convert _maxMarketValue string: "+ __maxMarketValue +" to int");
			}
		}

		public int Length { get { return 3; } }

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
					ret = _longname.ToString();
					break;
				case 1:
					ret = _minMarketValue.ToString();
					break;
				case 2:
					ret = _maxMarketValue.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "longname":
					ret = _longname.ToString();
					break;
				case "minMarketValue":
					ret = _minMarketValue.ToString();
					break;
				case "maxMarketValue":
					ret = _maxMarketValue.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "longname" + " : " + _longname.ToString() + "} ";
			ret += "{" + "minMarketValue" + " : " + _minMarketValue.ToString() + "} ";
			ret += "{" + "maxMarketValue" + " : " + _maxMarketValue.ToString() + "} ";
			return ret;
		}
	}
	public sealed class EconomyDB : IGoogle2uDB
	{
		public enum rowIds {
			WOOD, STONE, METAL
		};
		public string [] rowNames = {
			"WOOD", "STONE", "METAL"
		};
		public System.Collections.Generic.List<EconomyDBRow> Rows = new System.Collections.Generic.List<EconomyDBRow>();

		public static EconomyDB Instance
		{
			get { return NestedEconomyDB.instance; }
		}

		private class NestedEconomyDB
		{
			static NestedEconomyDB() { }
			internal static readonly EconomyDB instance = new EconomyDB();
		}

		private EconomyDB()
		{
			Rows.Add( new EconomyDBRow("WOOD", "Wood", "4", "6"));
			Rows.Add( new EconomyDBRow("STONE", "Stone", "8", "12"));
			Rows.Add( new EconomyDBRow("METAL", "Metal", "16", "24"));
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
		public EconomyDBRow GetRow(rowIds in_RowID)
		{
			EconomyDBRow ret = null;
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
		public EconomyDBRow GetRow(string in_RowString)
		{
			EconomyDBRow ret = null;
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
