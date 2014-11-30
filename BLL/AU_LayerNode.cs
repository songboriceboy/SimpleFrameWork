using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using System.Collections;
using DYH_DB.Model;
namespace DYH_DB.BLL
{
	/// <summary>
	/// AU_LayerNode
	/// </summary>
	public partial class AU_LayerNode
	{
		private readonly DYH_DB.DAL.AU_LayerNode dal=new DYH_DB.DAL.AU_LayerNode();
		public AU_LayerNode()
		{}
		#region  Method
        public void ReleaseSQLiteConnection(string strConString)
        {
            dal.ReleaseSQLiteConnection(strConString);
        }
        public void TransAdd(DYH_DB.Model.AU_LayerNode model, Hashtable SQLStringList, ArrayList arrayList)
        {
            dal.TransAdd(model, SQLStringList, arrayList);
        }
        public void ExecuteSqlTran(string strConString, Hashtable SQLStringList, ArrayList arrayList)
        {
            dal.ExecuteSqlTran(strConString, SQLStringList, arrayList);
        }
        public void ExecuteSql(string strConString, string SQLString)
        {
            dal.ExecuteSql(strConString, SQLString);
        }
		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId(string strConString)
		{
            return dal.GetMaxId(strConString);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AU_LayerNodeID)
		{
			return dal.Exists(AU_LayerNodeID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DYH_DB.Model.AU_LayerNode model)
		{
			dal.Add(model);
		}
        public void Add(string strConString, DYH_DB.Model.AU_LayerNode model)
        {
            dal.Add(strConString, model);
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(string strConString, DYH_DB.Model.AU_LayerNode model)
		{
            return dal.Update(strConString, model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int AU_LayerNodeID)
		{
			
			return dal.Delete(AU_LayerNodeID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string AU_LayerNodeIDlist )
		{
			return dal.DeleteList(AU_LayerNodeIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public DYH_DB.Model.AU_LayerNode GetModel(string strConString, int AU_LayerNodeID)
        {

            return dal.GetModel(strConString, AU_LayerNodeID);
        }

        public DataSet GetListTop1(string strConString, string strWhere)
        {
            return dal.GetListTop1(strConString, strWhere);
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strConString, string strWhere)
		{
            return dal.GetList(strConString, strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
        //public List<DYH_DB.Model.AU_LayerNode> GetModelList(string strWhere)
        //{
        //    DataSet ds = dal.GetList(strWhere);
        //    return DataTableToList(ds.Tables[0]);
        //}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<DYH_DB.Model.AU_LayerNode> DataTableToList(DataTable dt)
		{
			List<DYH_DB.Model.AU_LayerNode> modelList = new List<DYH_DB.Model.AU_LayerNode>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				DYH_DB.Model.AU_LayerNode model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new DYH_DB.Model.AU_LayerNode();
					if(dt.Rows[n]["AU_LayerNodeID"].ToString()!="")
					{
						model.AU_LayerNodeID=int.Parse(dt.Rows[n]["AU_LayerNodeID"].ToString());
					}
					if(dt.Rows[n]["AU_ParentLayerNodeID"].ToString()!="")
					{
						model.AU_ParentLayerNodeID=int.Parse(dt.Rows[n]["AU_ParentLayerNodeID"].ToString());
					}
					model.AU_UrlAddress=dt.Rows[n]["AU_UrlAddress"].ToString();
					model.AU_UrlTitle=dt.Rows[n]["AU_UrlTitle"].ToString();
					model.AU_UrlContent=dt.Rows[n]["AU_UrlContent"].ToString();
					if(dt.Rows[n]["AU_UrlLayer"].ToString()!="")
					{
						model.AU_UrlLayer=int.Parse(dt.Rows[n]["AU_UrlLayer"].ToString());
					}
					if(dt.Rows[n]["AU_IsVisit"].ToString()!="")
					{
						model.AU_IsVisit=int.Parse(dt.Rows[n]["AU_IsVisit"].ToString());
					}
					if(dt.Rows[n]["AU_RemoveSameOffset1"].ToString()!="")
					{
						model.AU_RemoveSameOffset1=int.Parse(dt.Rows[n]["AU_RemoveSameOffset1"].ToString());
					}
					if(dt.Rows[n]["AU_RemoveSameOffset2"].ToString()!="")
					{
						model.AU_RemoveSameOffset2=int.Parse(dt.Rows[n]["AU_RemoveSameOffset2"].ToString());
					}
					if(dt.Rows[n]["AU_LastUpdateDate"].ToString()!="")
					{
						model.AU_LastUpdateDate=DateTime.Parse(dt.Rows[n]["AU_LastUpdateDate"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveInt1"].ToString()!="")
					{
						model.AU_ReserveInt1=int.Parse(dt.Rows[n]["AU_ReserveInt1"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveInt2"].ToString()!="")
					{
						model.AU_ReserveInt2=int.Parse(dt.Rows[n]["AU_ReserveInt2"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveInt3"].ToString()!="")
					{
						model.AU_ReserveInt3=int.Parse(dt.Rows[n]["AU_ReserveInt3"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveInt4"].ToString()!="")
					{
						model.AU_ReserveInt4=int.Parse(dt.Rows[n]["AU_ReserveInt4"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveInt5"].ToString()!="")
					{
						model.AU_ReserveInt5=int.Parse(dt.Rows[n]["AU_ReserveInt5"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveInt6"].ToString()!="")
					{
						model.AU_ReserveInt6=int.Parse(dt.Rows[n]["AU_ReserveInt6"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveInt7"].ToString()!="")
					{
						model.AU_ReserveInt7=int.Parse(dt.Rows[n]["AU_ReserveInt7"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveInt8"].ToString()!="")
					{
						model.AU_ReserveInt8=int.Parse(dt.Rows[n]["AU_ReserveInt8"].ToString());
					}
					model.AU_ReserveStr1=dt.Rows[n]["AU_ReserveStr1"].ToString();
					model.AU_ReserveStr2=dt.Rows[n]["AU_ReserveStr2"].ToString();
					model.AU_ReserveNStr1=dt.Rows[n]["AU_ReserveNStr1"].ToString();
					model.AU_ReserveNStr2=dt.Rows[n]["AU_ReserveNStr2"].ToString();
					model.AU_ReserveTEXT1=dt.Rows[n]["AU_ReserveTEXT1"].ToString();
					model.AU_ReserveTEXT2=dt.Rows[n]["AU_ReserveTEXT2"].ToString();
					model.AU_ReserveTEXT3=dt.Rows[n]["AU_ReserveTEXT3"].ToString();
					model.AU_ReserveNTEXT1=dt.Rows[n]["AU_ReserveNTEXT1"].ToString();
					model.AU_ReserveNTEXT2=dt.Rows[n]["AU_ReserveNTEXT2"].ToString();
					model.AU_ReserveNTEXT3=dt.Rows[n]["AU_ReserveNTEXT3"].ToString();
					if(dt.Rows[n]["AU_ReserveDateTime1"].ToString()!="")
					{
						model.AU_ReserveDateTime1=DateTime.Parse(dt.Rows[n]["AU_ReserveDateTime1"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveDateTime2"].ToString()!="")
					{
						model.AU_ReserveDateTime2=DateTime.Parse(dt.Rows[n]["AU_ReserveDateTime2"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveDateTime3"].ToString()!="")
					{
						model.AU_ReserveDateTime3=DateTime.Parse(dt.Rows[n]["AU_ReserveDateTime3"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveDateTime4"].ToString()!="")
					{
						model.AU_ReserveDateTime4=DateTime.Parse(dt.Rows[n]["AU_ReserveDateTime4"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveDecmial1"].ToString()!="")
					{
						model.AU_ReserveDecmial1=decimal.Parse(dt.Rows[n]["AU_ReserveDecmial1"].ToString());
					}
					if(dt.Rows[n]["AU_ReserveDecmial2"].ToString()!="")
					{
						model.AU_ReserveDecmial2=decimal.Parse(dt.Rows[n]["AU_ReserveDecmial2"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
        //public DataSet GetAllList()
        //{
        //    return GetList("");
        //}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

