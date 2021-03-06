#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Alor.Metadata.Alor
File: AlorHoldingColumns.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Alor.Metadata
{
	/// <summary>
	/// ������� ��������� ������� HOLDING.
	/// </summary>
	public static class AlorHoldingColumns
	{
		/// <summary>
		/// ������������� ������.
		/// </summary>
		public static readonly AlorColumn Id = new AlorColumn(AlorTableTypes.Position, "ID", typeof(int), false);

		/// <summary>
		/// ������������� �������.
		/// </summary>
		public static readonly AlorColumn ClientId = new AlorColumn(AlorTableTypes.Position, "ClientID", typeof(int), false);

		/// <summary>
		/// ��� ��������� �����.
		/// </summary>
		public static readonly AlorColumn Account = new AlorColumn(AlorTableTypes.Position, "Account", typeof(string));

		/// <summary>
		/// ������ ���� &lt;���� �������&gt;[/&lt;�������&gt;].
		/// </summary>
		public static readonly AlorColumn BrokerRef = new AlorColumn(AlorTableTypes.Position, "BrokerRef", typeof(string), false);

		/// <summary>
		/// ������������� ����������� �����������.
		/// </summary>
		public static readonly AlorColumn SecurityCode = new AlorColumn(AlorTableTypes.Position, "SecCode", typeof(string));

		/// <summary>
		/// ��������� �������� ������� �� ������ ������ ������ �� ���� �������� ������ �������.
		/// </summary>
		public static readonly AlorColumn BeginValue = new AlorColumn(AlorTableTypes.Position, "OpenBal", typeof(int));

		/// <summary>
		/// ������� ������� � �������� ������� ���� ��������� ����� ����������� �������� ������ �� ������� ����� ��������� ����� ������ �� �������.
		/// </summary>
		public static readonly AlorColumn CurrentValue = new AlorColumn(AlorTableTypes.Position, "CurrentPos", typeof(int));

		/// <summary>
		/// ����������� �������� �������.
		/// </summary>
		public static readonly AlorColumn MinValue = new AlorColumn(AlorTableTypes.Position, "Min", typeof(int), false);

		/// <summary>
		/// ����� �������� ������ �� �������.
		/// </summary>
		public static readonly AlorColumn CurrentBidsVolume = new AlorColumn(AlorTableTypes.Position, "PlannedPosBuy", typeof(int));

		/// <summary>
		/// ����� �������� ������ �� �������.
		/// </summary>
        public static readonly AlorColumn CurrentAsksVolume = new AlorColumn(AlorTableTypes.Position, "PlannedPosSell", typeof(int));
	    
    }
}