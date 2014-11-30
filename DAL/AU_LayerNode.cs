using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using System.Collections;
using Maticsoft.DBUtility;//Please add references
namespace DYH_DB.DAL
{
	/// <summary>
	/// 数据访问类:AU_LayerNode
	/// </summary>
	public partial class AU_LayerNode
	{
		public AU_LayerNode()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
        public int GetMaxId(string strConString)
		{
		return DbHelperSQLite.GetMaxID(strConString, "AU_LayerNodeID", "AU_LayerNode"); 
		}

        public void ExecuteSqlTran(string strConString, Hashtable SQLStringList, ArrayList arrayList)
        {
            DbHelperSQLite.ExecuteSqlTran(strConString, SQLStringList, arrayList);
        }
        public void ExecuteSql(string strConString, string SQLString)
        {
            DbHelperSQLite.ExecuteSql(strConString, SQLString);
        }
        public void ReleaseSQLiteConnection(string strConString)
        {
            DbHelperSQLite.ReleaseSQLiteConnection(strConString);
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AU_LayerNodeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AU_LayerNode");
			strSql.Append(" where AU_LayerNodeID=@AU_LayerNodeID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AU_LayerNodeID", DbType.Int32,4)};
			parameters[0].Value = AU_LayerNodeID;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(string strConString, DYH_DB.Model.AU_LayerNode model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AU_LayerNode(");
			strSql.Append("AU_LayerNodeID,AU_ParentLayerNodeID,AU_UrlAddress,AU_UrlTitle,AU_UrlContent,AU_UrlLayer,AU_IsVisit,AU_RemoveSameOffset1,AU_RemoveSameOffset2,AU_LastUpdateDate,AU_ReserveInt1,AU_ReserveInt2,AU_ReserveInt3,AU_ReserveInt4,AU_ReserveInt5,AU_ReserveInt6,AU_ReserveInt7,AU_ReserveInt8,AU_ReserveStr1,AU_ReserveStr2,AU_ReserveNStr1,AU_ReserveNStr2,AU_ReserveTEXT1,AU_ReserveTEXT2,AU_ReserveTEXT3,AU_ReserveNTEXT1,AU_ReserveNTEXT2,AU_ReserveNTEXT3,AU_ReserveDateTime1,AU_ReserveDateTime2,AU_ReserveDateTime3,AU_ReserveDateTime4,AU_ReserveDecmial1,AU_ReserveDecmial2)");
			strSql.Append(" values (");
			strSql.Append("@AU_LayerNodeID,@AU_ParentLayerNodeID,@AU_UrlAddress,@AU_UrlTitle,@AU_UrlContent,@AU_UrlLayer,@AU_IsVisit,@AU_RemoveSameOffset1,@AU_RemoveSameOffset2,@AU_LastUpdateDate,@AU_ReserveInt1,@AU_ReserveInt2,@AU_ReserveInt3,@AU_ReserveInt4,@AU_ReserveInt5,@AU_ReserveInt6,@AU_ReserveInt7,@AU_ReserveInt8,@AU_ReserveStr1,@AU_ReserveStr2,@AU_ReserveNStr1,@AU_ReserveNStr2,@AU_ReserveTEXT1,@AU_ReserveTEXT2,@AU_ReserveTEXT3,@AU_ReserveNTEXT1,@AU_ReserveNTEXT2,@AU_ReserveNTEXT3,@AU_ReserveDateTime1,@AU_ReserveDateTime2,@AU_ReserveDateTime3,@AU_ReserveDateTime4,@AU_ReserveDecmial1,@AU_ReserveDecmial2)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AU_LayerNodeID", DbType.Int32,4),
					new SQLiteParameter("@AU_ParentLayerNodeID", DbType.Int32,4),
					new SQLiteParameter("@AU_UrlAddress", DbType.String,1000),
					new SQLiteParameter("@AU_UrlTitle", DbType.String),
					new SQLiteParameter("@AU_UrlContent", DbType.String),
					new SQLiteParameter("@AU_UrlLayer", DbType.Int32,4),
					new SQLiteParameter("@AU_IsVisit", DbType.Int32,4),
					new SQLiteParameter("@AU_RemoveSameOffset1", DbType.Int32,4),
					new SQLiteParameter("@AU_RemoveSameOffset2", DbType.Int32,4),
					new SQLiteParameter("@AU_LastUpdateDate", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveInt1", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt2", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt3", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt4", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt5", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt6", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt7", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt8", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveStr1", DbType.String,1000),
					new SQLiteParameter("@AU_ReserveStr2", DbType.String,1000),
					new SQLiteParameter("@AU_ReserveNStr1", DbType.String),
					new SQLiteParameter("@AU_ReserveNStr2", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT1", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT2", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT3", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT1", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT2", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT3", DbType.String),
					new SQLiteParameter("@AU_ReserveDateTime1", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime2", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime3", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime4", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDecmial1", DbType.Decimal,8),
					new SQLiteParameter("@AU_ReserveDecmial2", DbType.Decimal,8)};
			parameters[0].Value = model.AU_LayerNodeID;
			parameters[1].Value = model.AU_ParentLayerNodeID;
			parameters[2].Value = model.AU_UrlAddress;
			parameters[3].Value = model.AU_UrlTitle;
			parameters[4].Value = model.AU_UrlContent;
			parameters[5].Value = model.AU_UrlLayer;
			parameters[6].Value = model.AU_IsVisit;
			parameters[7].Value = model.AU_RemoveSameOffset1;
			parameters[8].Value = model.AU_RemoveSameOffset2;
			parameters[9].Value = model.AU_LastUpdateDate;
			parameters[10].Value = model.AU_ReserveInt1;
			parameters[11].Value = model.AU_ReserveInt2;
			parameters[12].Value = model.AU_ReserveInt3;
			parameters[13].Value = model.AU_ReserveInt4;
			parameters[14].Value = model.AU_ReserveInt5;
			parameters[15].Value = model.AU_ReserveInt6;
			parameters[16].Value = model.AU_ReserveInt7;
			parameters[17].Value = model.AU_ReserveInt8;
			parameters[18].Value = model.AU_ReserveStr1;
			parameters[19].Value = model.AU_ReserveStr2;
			parameters[20].Value = model.AU_ReserveNStr1;
			parameters[21].Value = model.AU_ReserveNStr2;
			parameters[22].Value = model.AU_ReserveTEXT1;
			parameters[23].Value = model.AU_ReserveTEXT2;
			parameters[24].Value = model.AU_ReserveTEXT3;
			parameters[25].Value = model.AU_ReserveNTEXT1;
			parameters[26].Value = model.AU_ReserveNTEXT2;
			parameters[27].Value = model.AU_ReserveNTEXT3;
			parameters[28].Value = model.AU_ReserveDateTime1;
			parameters[29].Value = model.AU_ReserveDateTime2;
			parameters[30].Value = model.AU_ReserveDateTime3;
			parameters[31].Value = model.AU_ReserveDateTime4;
			parameters[32].Value = model.AU_ReserveDecmial1;
			parameters[33].Value = model.AU_ReserveDecmial2;

            DbHelperSQLite.ExecuteSql(strConString, strSql.ToString(), parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(DYH_DB.Model.AU_LayerNode model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AU_LayerNode(");
            strSql.Append("AU_LayerNodeID,AU_ParentLayerNodeID,AU_UrlAddress,AU_UrlTitle,AU_UrlContent,AU_UrlLayer,AU_IsVisit,AU_RemoveSameOffset1,AU_RemoveSameOffset2,AU_LastUpdateDate,AU_ReserveInt1,AU_ReserveInt2,AU_ReserveInt3,AU_ReserveInt4,AU_ReserveInt5,AU_ReserveInt6,AU_ReserveInt7,AU_ReserveInt8,AU_ReserveStr1,AU_ReserveStr2,AU_ReserveNStr1,AU_ReserveNStr2,AU_ReserveTEXT1,AU_ReserveTEXT2,AU_ReserveTEXT3,AU_ReserveNTEXT1,AU_ReserveNTEXT2,AU_ReserveNTEXT3,AU_ReserveDateTime1,AU_ReserveDateTime2,AU_ReserveDateTime3,AU_ReserveDateTime4,AU_ReserveDecmial1,AU_ReserveDecmial2)");
            strSql.Append(" values (");
            strSql.Append("@AU_LayerNodeID,@AU_ParentLayerNodeID,@AU_UrlAddress,@AU_UrlTitle,@AU_UrlContent,@AU_UrlLayer,@AU_IsVisit,@AU_RemoveSameOffset1,@AU_RemoveSameOffset2,@AU_LastUpdateDate,@AU_ReserveInt1,@AU_ReserveInt2,@AU_ReserveInt3,@AU_ReserveInt4,@AU_ReserveInt5,@AU_ReserveInt6,@AU_ReserveInt7,@AU_ReserveInt8,@AU_ReserveStr1,@AU_ReserveStr2,@AU_ReserveNStr1,@AU_ReserveNStr2,@AU_ReserveTEXT1,@AU_ReserveTEXT2,@AU_ReserveTEXT3,@AU_ReserveNTEXT1,@AU_ReserveNTEXT2,@AU_ReserveNTEXT3,@AU_ReserveDateTime1,@AU_ReserveDateTime2,@AU_ReserveDateTime3,@AU_ReserveDateTime4,@AU_ReserveDecmial1,@AU_ReserveDecmial2)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@AU_LayerNodeID", DbType.Int32,4),
					new SQLiteParameter("@AU_ParentLayerNodeID", DbType.Int32,4),
					new SQLiteParameter("@AU_UrlAddress", DbType.String,1000),
					new SQLiteParameter("@AU_UrlTitle", DbType.String),
					new SQLiteParameter("@AU_UrlContent", DbType.String),
					new SQLiteParameter("@AU_UrlLayer", DbType.Int32,4),
					new SQLiteParameter("@AU_IsVisit", DbType.Int32,4),
					new SQLiteParameter("@AU_RemoveSameOffset1", DbType.Int32,4),
					new SQLiteParameter("@AU_RemoveSameOffset2", DbType.Int32,4),
					new SQLiteParameter("@AU_LastUpdateDate", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveInt1", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt2", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt3", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt4", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt5", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt6", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt7", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt8", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveStr1", DbType.String,1000),
					new SQLiteParameter("@AU_ReserveStr2", DbType.String,1000),
					new SQLiteParameter("@AU_ReserveNStr1", DbType.String),
					new SQLiteParameter("@AU_ReserveNStr2", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT1", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT2", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT3", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT1", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT2", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT3", DbType.String),
					new SQLiteParameter("@AU_ReserveDateTime1", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime2", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime3", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime4", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDecmial1", DbType.Decimal,8),
					new SQLiteParameter("@AU_ReserveDecmial2", DbType.Decimal,8)};
            parameters[0].Value = model.AU_LayerNodeID;
            parameters[1].Value = model.AU_ParentLayerNodeID;
            parameters[2].Value = model.AU_UrlAddress;
            parameters[3].Value = model.AU_UrlTitle;
            parameters[4].Value = model.AU_UrlContent;
            parameters[5].Value = model.AU_UrlLayer;
            parameters[6].Value = model.AU_IsVisit;
            parameters[7].Value = model.AU_RemoveSameOffset1;
            parameters[8].Value = model.AU_RemoveSameOffset2;
            parameters[9].Value = model.AU_LastUpdateDate;
            parameters[10].Value = model.AU_ReserveInt1;
            parameters[11].Value = model.AU_ReserveInt2;
            parameters[12].Value = model.AU_ReserveInt3;
            parameters[13].Value = model.AU_ReserveInt4;
            parameters[14].Value = model.AU_ReserveInt5;
            parameters[15].Value = model.AU_ReserveInt6;
            parameters[16].Value = model.AU_ReserveInt7;
            parameters[17].Value = model.AU_ReserveInt8;
            parameters[18].Value = model.AU_ReserveStr1;
            parameters[19].Value = model.AU_ReserveStr2;
            parameters[20].Value = model.AU_ReserveNStr1;
            parameters[21].Value = model.AU_ReserveNStr2;
            parameters[22].Value = model.AU_ReserveTEXT1;
            parameters[23].Value = model.AU_ReserveTEXT2;
            parameters[24].Value = model.AU_ReserveTEXT3;
            parameters[25].Value = model.AU_ReserveNTEXT1;
            parameters[26].Value = model.AU_ReserveNTEXT2;
            parameters[27].Value = model.AU_ReserveNTEXT3;
            parameters[28].Value = model.AU_ReserveDateTime1;
            parameters[29].Value = model.AU_ReserveDateTime2;
            parameters[30].Value = model.AU_ReserveDateTime3;
            parameters[31].Value = model.AU_ReserveDateTime4;
            parameters[32].Value = model.AU_ReserveDecmial1;
            parameters[33].Value = model.AU_ReserveDecmial2;

            DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void TransAdd(DYH_DB.Model.AU_LayerNode model, Hashtable SQLStringList, ArrayList arrayList)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AU_LayerNode(");
            strSql.Append("AU_LayerNodeID,AU_ParentLayerNodeID,AU_UrlAddress,AU_UrlTitle,AU_UrlContent,AU_UrlLayer,AU_IsVisit,AU_RemoveSameOffset1,AU_RemoveSameOffset2,AU_LastUpdateDate,AU_ReserveInt1,AU_ReserveInt2,AU_ReserveInt3,AU_ReserveInt4,AU_ReserveInt5,AU_ReserveInt6,AU_ReserveInt7,AU_ReserveInt8,AU_ReserveStr1,AU_ReserveStr2,AU_ReserveNStr1,AU_ReserveNStr2,AU_ReserveTEXT1,AU_ReserveTEXT2,AU_ReserveTEXT3,AU_ReserveNTEXT1,AU_ReserveNTEXT2,AU_ReserveNTEXT3,AU_ReserveDateTime1,AU_ReserveDateTime2,AU_ReserveDateTime3,AU_ReserveDateTime4,AU_ReserveDecmial1,AU_ReserveDecmial2)");
            strSql.Append(" values (");
            strSql.Append("@AU_LayerNodeID,@AU_ParentLayerNodeID,@AU_UrlAddress,@AU_UrlTitle,@AU_UrlContent,@AU_UrlLayer,@AU_IsVisit,@AU_RemoveSameOffset1,@AU_RemoveSameOffset2,@AU_LastUpdateDate,@AU_ReserveInt1,@AU_ReserveInt2,@AU_ReserveInt3,@AU_ReserveInt4,@AU_ReserveInt5,@AU_ReserveInt6,@AU_ReserveInt7,@AU_ReserveInt8,@AU_ReserveStr1,@AU_ReserveStr2,@AU_ReserveNStr1,@AU_ReserveNStr2,@AU_ReserveTEXT1,@AU_ReserveTEXT2,@AU_ReserveTEXT3,@AU_ReserveNTEXT1,@AU_ReserveNTEXT2,@AU_ReserveNTEXT3,@AU_ReserveDateTime1,@AU_ReserveDateTime2,@AU_ReserveDateTime3,@AU_ReserveDateTime4,@AU_ReserveDecmial1,@AU_ReserveDecmial2)");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@AU_LayerNodeID", DbType.Int32,4),
					new SQLiteParameter("@AU_ParentLayerNodeID", DbType.Int32,4),
					new SQLiteParameter("@AU_UrlAddress", DbType.String,1000),
					new SQLiteParameter("@AU_UrlTitle", DbType.String),
					new SQLiteParameter("@AU_UrlContent", DbType.String),
					new SQLiteParameter("@AU_UrlLayer", DbType.Int32,4),
					new SQLiteParameter("@AU_IsVisit", DbType.Int32,4),
					new SQLiteParameter("@AU_RemoveSameOffset1", DbType.Int32,4),
					new SQLiteParameter("@AU_RemoveSameOffset2", DbType.Int32,4),
					new SQLiteParameter("@AU_LastUpdateDate", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveInt1", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt2", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt3", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt4", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt5", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt6", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt7", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt8", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveStr1", DbType.String,1000),
					new SQLiteParameter("@AU_ReserveStr2", DbType.String,1000),
					new SQLiteParameter("@AU_ReserveNStr1", DbType.String),
					new SQLiteParameter("@AU_ReserveNStr2", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT1", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT2", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT3", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT1", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT2", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT3", DbType.String),
					new SQLiteParameter("@AU_ReserveDateTime1", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime2", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime3", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime4", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDecmial1", DbType.Decimal,8),
					new SQLiteParameter("@AU_ReserveDecmial2", DbType.Decimal,8)};
            parameters[0].Value = model.AU_LayerNodeID;
            parameters[1].Value = model.AU_ParentLayerNodeID;
            parameters[2].Value = model.AU_UrlAddress;
            parameters[3].Value = model.AU_UrlTitle;
            parameters[4].Value = model.AU_UrlContent;
            parameters[5].Value = model.AU_UrlLayer;
            parameters[6].Value = model.AU_IsVisit;
            parameters[7].Value = model.AU_RemoveSameOffset1;
            parameters[8].Value = model.AU_RemoveSameOffset2;
            parameters[9].Value = model.AU_LastUpdateDate;
            parameters[10].Value = model.AU_ReserveInt1;
            parameters[11].Value = model.AU_ReserveInt2;
            parameters[12].Value = model.AU_ReserveInt3;
            parameters[13].Value = model.AU_ReserveInt4;
            parameters[14].Value = model.AU_ReserveInt5;
            parameters[15].Value = model.AU_ReserveInt6;
            parameters[16].Value = model.AU_ReserveInt7;
            parameters[17].Value = model.AU_ReserveInt8;
            parameters[18].Value = model.AU_ReserveStr1;
            parameters[19].Value = model.AU_ReserveStr2;
            parameters[20].Value = model.AU_ReserveNStr1;
            parameters[21].Value = model.AU_ReserveNStr2;
            parameters[22].Value = model.AU_ReserveTEXT1;
            parameters[23].Value = model.AU_ReserveTEXT2;
            parameters[24].Value = model.AU_ReserveTEXT3;
            parameters[25].Value = model.AU_ReserveNTEXT1;
            parameters[26].Value = model.AU_ReserveNTEXT2;
            parameters[27].Value = model.AU_ReserveNTEXT3;
            parameters[28].Value = model.AU_ReserveDateTime1;
            parameters[29].Value = model.AU_ReserveDateTime2;
            parameters[30].Value = model.AU_ReserveDateTime3;
            parameters[31].Value = model.AU_ReserveDateTime4;
            parameters[32].Value = model.AU_ReserveDecmial1;
            parameters[33].Value = model.AU_ReserveDecmial2;

            arrayList.Add(strSql.ToString());
            SQLStringList.Add(arrayList.Count, parameters);
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(string strConString, DYH_DB.Model.AU_LayerNode model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AU_LayerNode set ");
			strSql.Append("AU_ParentLayerNodeID=@AU_ParentLayerNodeID,");
			strSql.Append("AU_UrlAddress=@AU_UrlAddress,");
			strSql.Append("AU_UrlTitle=@AU_UrlTitle,");
			strSql.Append("AU_UrlContent=@AU_UrlContent,");
			strSql.Append("AU_UrlLayer=@AU_UrlLayer,");
			strSql.Append("AU_IsVisit=@AU_IsVisit,");
			strSql.Append("AU_RemoveSameOffset1=@AU_RemoveSameOffset1,");
			strSql.Append("AU_RemoveSameOffset2=@AU_RemoveSameOffset2,");
			strSql.Append("AU_LastUpdateDate=@AU_LastUpdateDate,");
			strSql.Append("AU_ReserveInt1=@AU_ReserveInt1,");
			strSql.Append("AU_ReserveInt2=@AU_ReserveInt2,");
			strSql.Append("AU_ReserveInt3=@AU_ReserveInt3,");
			strSql.Append("AU_ReserveInt4=@AU_ReserveInt4,");
			strSql.Append("AU_ReserveInt5=@AU_ReserveInt5,");
			strSql.Append("AU_ReserveInt6=@AU_ReserveInt6,");
			strSql.Append("AU_ReserveInt7=@AU_ReserveInt7,");
			strSql.Append("AU_ReserveInt8=@AU_ReserveInt8,");
			strSql.Append("AU_ReserveStr1=@AU_ReserveStr1,");
			strSql.Append("AU_ReserveStr2=@AU_ReserveStr2,");
			strSql.Append("AU_ReserveNStr1=@AU_ReserveNStr1,");
			strSql.Append("AU_ReserveNStr2=@AU_ReserveNStr2,");
			strSql.Append("AU_ReserveTEXT1=@AU_ReserveTEXT1,");
			strSql.Append("AU_ReserveTEXT2=@AU_ReserveTEXT2,");
			strSql.Append("AU_ReserveTEXT3=@AU_ReserveTEXT3,");
			strSql.Append("AU_ReserveNTEXT1=@AU_ReserveNTEXT1,");
			strSql.Append("AU_ReserveNTEXT2=@AU_ReserveNTEXT2,");
			strSql.Append("AU_ReserveNTEXT3=@AU_ReserveNTEXT3,");
			strSql.Append("AU_ReserveDateTime1=@AU_ReserveDateTime1,");
			strSql.Append("AU_ReserveDateTime2=@AU_ReserveDateTime2,");
			strSql.Append("AU_ReserveDateTime3=@AU_ReserveDateTime3,");
			strSql.Append("AU_ReserveDateTime4=@AU_ReserveDateTime4,");
			strSql.Append("AU_ReserveDecmial1=@AU_ReserveDecmial1,");
			strSql.Append("AU_ReserveDecmial2=@AU_ReserveDecmial2");
			strSql.Append(" where AU_LayerNodeID=@AU_LayerNodeID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AU_ParentLayerNodeID", DbType.Int32,4),
					new SQLiteParameter("@AU_UrlAddress", DbType.String,1000),
					new SQLiteParameter("@AU_UrlTitle", DbType.String),
					new SQLiteParameter("@AU_UrlContent", DbType.String),
					new SQLiteParameter("@AU_UrlLayer", DbType.Int32,4),
					new SQLiteParameter("@AU_IsVisit", DbType.Int32,4),
					new SQLiteParameter("@AU_RemoveSameOffset1", DbType.Int32,4),
					new SQLiteParameter("@AU_RemoveSameOffset2", DbType.Int32,4),
					new SQLiteParameter("@AU_LastUpdateDate", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveInt1", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt2", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt3", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt4", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt5", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt6", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt7", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveInt8", DbType.Int32,4),
					new SQLiteParameter("@AU_ReserveStr1", DbType.String,1000),
					new SQLiteParameter("@AU_ReserveStr2", DbType.String,1000),
					new SQLiteParameter("@AU_ReserveNStr1", DbType.String),
					new SQLiteParameter("@AU_ReserveNStr2", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT1", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT2", DbType.String),
					new SQLiteParameter("@AU_ReserveTEXT3", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT1", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT2", DbType.String),
					new SQLiteParameter("@AU_ReserveNTEXT3", DbType.String),
					new SQLiteParameter("@AU_ReserveDateTime1", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime2", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime3", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDateTime4", DbType.DateTime),
					new SQLiteParameter("@AU_ReserveDecmial1", DbType.Decimal,8),
					new SQLiteParameter("@AU_ReserveDecmial2", DbType.Decimal,8),
					new SQLiteParameter("@AU_LayerNodeID", DbType.Int32,4)};
			parameters[0].Value = model.AU_ParentLayerNodeID;
			parameters[1].Value = model.AU_UrlAddress;
			parameters[2].Value = model.AU_UrlTitle;
			parameters[3].Value = model.AU_UrlContent;
			parameters[4].Value = model.AU_UrlLayer;
			parameters[5].Value = model.AU_IsVisit;
			parameters[6].Value = model.AU_RemoveSameOffset1;
			parameters[7].Value = model.AU_RemoveSameOffset2;
			parameters[8].Value = model.AU_LastUpdateDate;
			parameters[9].Value = model.AU_ReserveInt1;
			parameters[10].Value = model.AU_ReserveInt2;
			parameters[11].Value = model.AU_ReserveInt3;
			parameters[12].Value = model.AU_ReserveInt4;
			parameters[13].Value = model.AU_ReserveInt5;
			parameters[14].Value = model.AU_ReserveInt6;
			parameters[15].Value = model.AU_ReserveInt7;
			parameters[16].Value = model.AU_ReserveInt8;
			parameters[17].Value = model.AU_ReserveStr1;
			parameters[18].Value = model.AU_ReserveStr2;
			parameters[19].Value = model.AU_ReserveNStr1;
			parameters[20].Value = model.AU_ReserveNStr2;
			parameters[21].Value = model.AU_ReserveTEXT1;
			parameters[22].Value = model.AU_ReserveTEXT2;
			parameters[23].Value = model.AU_ReserveTEXT3;
			parameters[24].Value = model.AU_ReserveNTEXT1;
			parameters[25].Value = model.AU_ReserveNTEXT2;
			parameters[26].Value = model.AU_ReserveNTEXT3;
			parameters[27].Value = model.AU_ReserveDateTime1;
			parameters[28].Value = model.AU_ReserveDateTime2;
			parameters[29].Value = model.AU_ReserveDateTime3;
			parameters[30].Value = model.AU_ReserveDateTime4;
			parameters[31].Value = model.AU_ReserveDecmial1;
			parameters[32].Value = model.AU_ReserveDecmial2;
			parameters[33].Value = model.AU_LayerNodeID;

            int rows = DbHelperSQLite.ExecuteSql(strConString, strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int AU_LayerNodeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AU_LayerNode ");
			strSql.Append(" where AU_LayerNodeID=@AU_LayerNodeID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AU_LayerNodeID", DbType.Int32,4)};
			parameters[0].Value = AU_LayerNodeID;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string AU_LayerNodeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AU_LayerNode ");
			strSql.Append(" where AU_LayerNodeID in ("+AU_LayerNodeIDlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public DYH_DB.Model.AU_LayerNode GetModel(string strConString, int AU_LayerNodeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AU_LayerNodeID,AU_ParentLayerNodeID,AU_UrlAddress,AU_UrlTitle,AU_UrlContent,AU_UrlLayer,AU_IsVisit,AU_RemoveSameOffset1,AU_RemoveSameOffset2,AU_LastUpdateDate,AU_ReserveInt1,AU_ReserveInt2,AU_ReserveInt3,AU_ReserveInt4,AU_ReserveInt5,AU_ReserveInt6,AU_ReserveInt7,AU_ReserveInt8,AU_ReserveStr1,AU_ReserveStr2,AU_ReserveNStr1,AU_ReserveNStr2,AU_ReserveTEXT1,AU_ReserveTEXT2,AU_ReserveTEXT3,AU_ReserveNTEXT1,AU_ReserveNTEXT2,AU_ReserveNTEXT3,AU_ReserveDateTime1,AU_ReserveDateTime2,AU_ReserveDateTime3,AU_ReserveDateTime4,AU_ReserveDecmial1,AU_ReserveDecmial2 from AU_LayerNode ");
			strSql.Append(" where AU_LayerNodeID=@AU_LayerNodeID ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@AU_LayerNodeID", DbType.Int32,4)};
			parameters[0].Value = AU_LayerNodeID;

			DYH_DB.Model.AU_LayerNode model=new DYH_DB.Model.AU_LayerNode();
            DataSet ds = DbHelperSQLite.Query(strConString, strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["AU_LayerNodeID"].ToString()!="")
				{
					model.AU_LayerNodeID=int.Parse(ds.Tables[0].Rows[0]["AU_LayerNodeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ParentLayerNodeID"].ToString()!="")
				{
					model.AU_ParentLayerNodeID=int.Parse(ds.Tables[0].Rows[0]["AU_ParentLayerNodeID"].ToString());
				}
				model.AU_UrlAddress=ds.Tables[0].Rows[0]["AU_UrlAddress"].ToString();
				model.AU_UrlTitle=ds.Tables[0].Rows[0]["AU_UrlTitle"].ToString();
				model.AU_UrlContent=ds.Tables[0].Rows[0]["AU_UrlContent"].ToString();
				if(ds.Tables[0].Rows[0]["AU_UrlLayer"].ToString()!="")
				{
					model.AU_UrlLayer=int.Parse(ds.Tables[0].Rows[0]["AU_UrlLayer"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_IsVisit"].ToString()!="")
				{
					model.AU_IsVisit=int.Parse(ds.Tables[0].Rows[0]["AU_IsVisit"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_RemoveSameOffset1"].ToString()!="")
				{
					model.AU_RemoveSameOffset1=int.Parse(ds.Tables[0].Rows[0]["AU_RemoveSameOffset1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_RemoveSameOffset2"].ToString()!="")
				{
					model.AU_RemoveSameOffset2=int.Parse(ds.Tables[0].Rows[0]["AU_RemoveSameOffset2"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_LastUpdateDate"].ToString()!="")
				{
					model.AU_LastUpdateDate=DateTime.Parse(ds.Tables[0].Rows[0]["AU_LastUpdateDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveInt1"].ToString()!="")
				{
					model.AU_ReserveInt1=int.Parse(ds.Tables[0].Rows[0]["AU_ReserveInt1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveInt2"].ToString()!="")
				{
					model.AU_ReserveInt2=int.Parse(ds.Tables[0].Rows[0]["AU_ReserveInt2"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveInt3"].ToString()!="")
				{
					model.AU_ReserveInt3=int.Parse(ds.Tables[0].Rows[0]["AU_ReserveInt3"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveInt4"].ToString()!="")
				{
					model.AU_ReserveInt4=int.Parse(ds.Tables[0].Rows[0]["AU_ReserveInt4"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveInt5"].ToString()!="")
				{
					model.AU_ReserveInt5=int.Parse(ds.Tables[0].Rows[0]["AU_ReserveInt5"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveInt6"].ToString()!="")
				{
					model.AU_ReserveInt6=int.Parse(ds.Tables[0].Rows[0]["AU_ReserveInt6"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveInt7"].ToString()!="")
				{
					model.AU_ReserveInt7=int.Parse(ds.Tables[0].Rows[0]["AU_ReserveInt7"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveInt8"].ToString()!="")
				{
					model.AU_ReserveInt8=int.Parse(ds.Tables[0].Rows[0]["AU_ReserveInt8"].ToString());
				}
				model.AU_ReserveStr1=ds.Tables[0].Rows[0]["AU_ReserveStr1"].ToString();
				model.AU_ReserveStr2=ds.Tables[0].Rows[0]["AU_ReserveStr2"].ToString();
				model.AU_ReserveNStr1=ds.Tables[0].Rows[0]["AU_ReserveNStr1"].ToString();
				model.AU_ReserveNStr2=ds.Tables[0].Rows[0]["AU_ReserveNStr2"].ToString();
				model.AU_ReserveTEXT1=ds.Tables[0].Rows[0]["AU_ReserveTEXT1"].ToString();
				model.AU_ReserveTEXT2=ds.Tables[0].Rows[0]["AU_ReserveTEXT2"].ToString();
				model.AU_ReserveTEXT3=ds.Tables[0].Rows[0]["AU_ReserveTEXT3"].ToString();
				model.AU_ReserveNTEXT1=ds.Tables[0].Rows[0]["AU_ReserveNTEXT1"].ToString();
				model.AU_ReserveNTEXT2=ds.Tables[0].Rows[0]["AU_ReserveNTEXT2"].ToString();
				model.AU_ReserveNTEXT3=ds.Tables[0].Rows[0]["AU_ReserveNTEXT3"].ToString();
				if(ds.Tables[0].Rows[0]["AU_ReserveDateTime1"].ToString()!="")
				{
					model.AU_ReserveDateTime1=DateTime.Parse(ds.Tables[0].Rows[0]["AU_ReserveDateTime1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveDateTime2"].ToString()!="")
				{
					model.AU_ReserveDateTime2=DateTime.Parse(ds.Tables[0].Rows[0]["AU_ReserveDateTime2"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveDateTime3"].ToString()!="")
				{
					model.AU_ReserveDateTime3=DateTime.Parse(ds.Tables[0].Rows[0]["AU_ReserveDateTime3"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveDateTime4"].ToString()!="")
				{
					model.AU_ReserveDateTime4=DateTime.Parse(ds.Tables[0].Rows[0]["AU_ReserveDateTime4"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveDecmial1"].ToString()!="")
				{
					model.AU_ReserveDecmial1=decimal.Parse(ds.Tables[0].Rows[0]["AU_ReserveDecmial1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AU_ReserveDecmial2"].ToString()!="")
				{
					model.AU_ReserveDecmial2=decimal.Parse(ds.Tables[0].Rows[0]["AU_ReserveDecmial2"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>AU_ReserveInt8 是否已经留推广评论
        public DataSet GetListTop1(string strConString, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select AU_LayerNodeID

,AU_UrlAddress
,AU_IsVisit
,AU_UrlTitle
,AU_UrlContent
,AU_ReserveInt1
,AU_ReserveInt2
,AU_ReserveInt3
,AU_ReserveNTEXT1
,AU_ReserveNTEXT2
,AU_ReserveTEXT1
,AU_ReserveTEXT2
,AU_ReserveStr1
,AU_ReserveStr2
,AU_ReserveTEXT3
,AU_ReserveInt8 
,AU_ReserveDecmial1

 ");
            strSql.Append(" FROM AU_LayerNode ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" limit 0,1 ");
            return DbHelperSQLite.Query(strConString, strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strConString, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select AU_LayerNodeID
,AU_ParentLayerNodeID
,AU_UrlAddress
,AU_UrlTitle 博文标题
,AU_ReserveNStr1 博文分类
,AU_ReserveDateTime1 发表时间
,AU_UrlContent
,AU_UrlLayer
,AU_IsVisit
,AU_RemoveSameOffset1
,AU_RemoveSameOffset2
,AU_LastUpdateDate ");
            strSql.Append(" FROM AU_LayerNode ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by AU_ReserveDateTime1 ");
            return DbHelperSQLite.Query(strConString, strSql.ToString());
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
        //public DataSet GetList(string strConString, string strWhere)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select AU_LayerNodeID,AU_ParentLayerNodeID,AU_UrlAddress,AU_UrlTitle,AU_UrlContent,AU_UrlLayer,AU_IsVisit,AU_RemoveSameOffset1,AU_RemoveSameOffset2,AU_LastUpdateDate,AU_ReserveInt1,AU_ReserveInt2,AU_ReserveInt3,AU_ReserveInt4,AU_ReserveInt5,AU_ReserveInt6,AU_ReserveInt7,AU_ReserveInt8,AU_ReserveStr1,AU_ReserveStr2,AU_ReserveNStr1,AU_ReserveNStr2,AU_ReserveTEXT1,AU_ReserveTEXT2,AU_ReserveTEXT3,AU_ReserveNTEXT1,AU_ReserveNTEXT2,AU_ReserveNTEXT3,AU_ReserveDateTime1,AU_ReserveDateTime2,AU_ReserveDateTime3,AU_ReserveDateTime4,AU_ReserveDecmial1,AU_ReserveDecmial2 ");
        //    strSql.Append(" FROM AU_LayerNode ");
        //    if(strWhere.Trim()!="")
        //    {
        //        strSql.Append(" where "+strWhere);
        //    }
        //    return DbHelperSQLite.Query(strConString, strSql.ToString());
        //}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "AU_LayerNode";
			parameters[1].Value = "AU_LayerNodeID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

