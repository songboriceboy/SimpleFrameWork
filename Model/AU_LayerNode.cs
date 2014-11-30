using System;
namespace DYH_DB.Model
{
	/// <summary>
	/// AU_LayerNode:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AU_LayerNode
	{
		public AU_LayerNode()
		{}
		#region Model
		private int _au_layernodeid;
		private int _au_parentlayernodeid=0;
		private string _au_urladdress="";
		private string _au_urltitle="";
		private string _au_urlcontent="";
		private int _au_urllayer=0;
		private int _au_isvisit=0;
		private int _au_removesameoffset1=0;
		private int _au_removesameoffset2=0;
		private DateTime _au_lastupdatedate= Convert.ToDateTime("2012-01-01");
		private int _au_reserveint1=0;
		private int _au_reserveint2=0;
		private int _au_reserveint3=0;
		private int _au_reserveint4=0;
		private int _au_reserveint5=0;
		private int _au_reserveint6=0;
		private int _au_reserveint7=0;
		private int _au_reserveint8=0;
		private string _au_reservestr1="";
		private string _au_reservestr2="";
		private string _au_reservenstr1="";
		private string _au_reservenstr2="";
		private string _au_reservetext1="";
		private string _au_reservetext2="";
		private string _au_reservetext3="";
		private string _au_reserventext1="";
		private string _au_reserventext2="";
		private string _au_reserventext3="";
		private DateTime _au_reservedatetime1= Convert.ToDateTime("2012-01-01");
		private DateTime _au_reservedatetime2= Convert.ToDateTime("2012-01-01");
		private DateTime _au_reservedatetime3= Convert.ToDateTime("2012-01-01");
		private DateTime _au_reservedatetime4= Convert.ToDateTime("2012-01-01");
		private decimal _au_reservedecmial1=0M;
		private decimal _au_reservedecmial2=0M;
		/// <summary>
		/// 
		/// </summary>
		public int AU_LayerNodeID
		{
			set{ _au_layernodeid=value;}
			get{return _au_layernodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ParentLayerNodeID
		{
			set{ _au_parentlayernodeid=value;}
			get{return _au_parentlayernodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_UrlAddress
		{
			set{ _au_urladdress=value;}
			get{return _au_urladdress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_UrlTitle
		{
			set{ _au_urltitle=value;}
			get{return _au_urltitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_UrlContent
		{
			set{ _au_urlcontent=value;}
			get{return _au_urlcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_UrlLayer
		{
			set{ _au_urllayer=value;}
			get{return _au_urllayer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_IsVisit
		{
			set{ _au_isvisit=value;}
			get{return _au_isvisit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_RemoveSameOffset1
		{
			set{ _au_removesameoffset1=value;}
			get{return _au_removesameoffset1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_RemoveSameOffset2
		{
			set{ _au_removesameoffset2=value;}
			get{return _au_removesameoffset2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AU_LastUpdateDate
		{
			set{ _au_lastupdatedate=value;}
			get{return _au_lastupdatedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ReserveInt1
		{
			set{ _au_reserveint1=value;}
			get{return _au_reserveint1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ReserveInt2
		{
			set{ _au_reserveint2=value;}
			get{return _au_reserveint2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ReserveInt3
		{
			set{ _au_reserveint3=value;}
			get{return _au_reserveint3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ReserveInt4
		{
			set{ _au_reserveint4=value;}
			get{return _au_reserveint4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ReserveInt5
		{
			set{ _au_reserveint5=value;}
			get{return _au_reserveint5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ReserveInt6
		{
			set{ _au_reserveint6=value;}
			get{return _au_reserveint6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ReserveInt7
		{
			set{ _au_reserveint7=value;}
			get{return _au_reserveint7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AU_ReserveInt8
		{
			set{ _au_reserveint8=value;}
			get{return _au_reserveint8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveStr1
		{
			set{ _au_reservestr1=value;}
			get{return _au_reservestr1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveStr2
		{
			set{ _au_reservestr2=value;}
			get{return _au_reservestr2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveNStr1
		{
			set{ _au_reservenstr1=value;}
			get{return _au_reservenstr1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveNStr2
		{
			set{ _au_reservenstr2=value;}
			get{return _au_reservenstr2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveTEXT1
		{
			set{ _au_reservetext1=value;}
			get{return _au_reservetext1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveTEXT2
		{
			set{ _au_reservetext2=value;}
			get{return _au_reservetext2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveTEXT3
		{
			set{ _au_reservetext3=value;}
			get{return _au_reservetext3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveNTEXT1
		{
			set{ _au_reserventext1=value;}
			get{return _au_reserventext1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveNTEXT2
		{
			set{ _au_reserventext2=value;}
			get{return _au_reserventext2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AU_ReserveNTEXT3
		{
			set{ _au_reserventext3=value;}
			get{return _au_reserventext3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AU_ReserveDateTime1
		{
			set{ _au_reservedatetime1=value;}
			get{return _au_reservedatetime1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AU_ReserveDateTime2
		{
			set{ _au_reservedatetime2=value;}
			get{return _au_reservedatetime2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AU_ReserveDateTime3
		{
			set{ _au_reservedatetime3=value;}
			get{return _au_reservedatetime3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AU_ReserveDateTime4
		{
			set{ _au_reservedatetime4=value;}
			get{return _au_reservedatetime4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal AU_ReserveDecmial1
		{
			set{ _au_reservedecmial1=value;}
			get{return _au_reservedecmial1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal AU_ReserveDecmial2
		{
			set{ _au_reservedecmial2=value;}
			get{return _au_reservedecmial2;}
		}
		#endregion Model

	}
}

