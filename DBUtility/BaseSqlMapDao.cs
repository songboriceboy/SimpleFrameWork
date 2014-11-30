using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

using IBatisNet.Common;
using IBatisNet.Common.Pagination;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Exceptions;
using IBatisNet.DataMapper.Configuration;

namespace Maticsoft.DBUtility
{
    /// <summary>
    /// ����IBatisNet�����ݷ��ʻ��� 
    /// </summary>
    public class BaseSqlMapDao 
    {
        private ISqlMapper sqlMap;
        public BaseSqlMapDao()
        {
            //DomSqlMapBuilder builder = new DomSqlMapBuilder(true);
            //sqlMap = builder.Configure();

            Assembly assembly = Assembly.Load("IBatisNetDemo");
            Stream stream = assembly.GetManifestResourceStream("IBatisNetDemo.sqlmap.config");

            DomSqlMapBuilder builder = new DomSqlMapBuilder();            
            sqlMap = builder.Configure(stream);
        }

        ///// <summary>
        ///// IsqlMapperʵ��
        ///// </summary>
        ///// <returns></returns>
        //public static ISqlMapper sqlMap = (ContainerAccessorUtil.GetContainer())["sqlServerSqlMap"] as ISqlMapper;

        //public SqlMapper SqlMap
        //{
        //    get
        //    {
        //        Assembly assembly = Assembly.Load("IBatisNetDemo");
        //        Stream stream = assembly.GetManifestResourceStream("IBatisNetDemo.sqlmap.config");

        //        DomSqlMapBuilder builder = new DomSqlMapBuilder();
        //        builder.
        //        SqlMapper sqlMap = builder.Configure(stream);
        //    }
        //}

        /// <summary>
        /// �õ��б�
        /// </summary>
        /// <typeparam name="T">ʵ������</typeparam>
        /// <param name="statementName">�������ƣ���Ӧxml�е�Statement��id</param>
        /// <param name="parameterObject">����</param>
        /// <returns></returns>
        protected IList<T> ExecuteQueryForList<T>(string statementName, object parameterObject)
        {
            try
            {
                return sqlMap.QueryForList<T>(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// �õ�ָ�������ļ�¼��
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="statementName"></param>
        /// <param name="parameterObject">����</param>
        /// <param name="skipResults">�����ļ�¼��</param>
        /// <param name="maxResults">��󷵻صļ�¼��</param>
        /// <returns></returns>
        protected IList<T> ExecuteQueryForList<T>(string statementName, object parameterObject, int skipResults, int maxResults)
        {
            try
            {
                return sqlMap.QueryForList<T>(statementName, parameterObject, skipResults, maxResults);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for list.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// �õ���ҳ���б�
        /// </summary>
        /// <param name="statementName">��������</param>
        /// <param name="parameterObject">����</param>
        /// <param name="pageSize">ÿҳ��¼��</param>
        /// <returns></returns>
        protected IPaginatedList ExecuteQueryForPaginatedList(string statementName, object parameterObject, int pageSize)
        {
            try
            {
                return sqlMap.QueryForPaginatedList(statementName, parameterObject, pageSize);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for paginated list.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// ��ѯ�õ������һ��ʵ��
        /// </summary>
        /// <typeparam name="T">����type</typeparam>
        /// <param name="statementName">������</param>
        /// <param name="parameterObject">����</param>
        /// <returns></returns>
        protected T ExecuteQueryForObject<T>(string statementName, object parameterObject)
        {
            try
            {
                return sqlMap.QueryForObject<T>(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for object.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// ִ�����
        /// </summary>
        /// <param name="statementName">������</param>
        /// <param name="parameterObject">����</param>
        protected void ExecuteInsert(string statementName, object parameterObject)
        {
            try
            {
                sqlMap.Insert(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for insert.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// ִ���޸�
        /// </summary>
        /// <param name="statementName">������</param>
        /// <param name="parameterObject">����</param>
        protected void ExecuteUpdate(string statementName, object parameterObject)
        {
            try
            {
                sqlMap.Update(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for update.  Cause: " + e.Message, e);
            }
        }

        /// <summary>
        /// ִ��ɾ��
        /// </summary>
        /// <param name="statementName">������</param>
        /// <param name="parameterObject">����</param>
        protected void ExecuteDelete(string statementName, object parameterObject)
        {
            try
            {
                sqlMap.Delete(statementName, parameterObject);
            }
            catch (Exception e)
            {
                throw new DataMapperException("Error executing query '" + statementName + "' for delete.  Cause: " + e.Message, e);
            }
        }

        ///// <summary>
        ///// �õ���ˮ��
        ///// </summary>
        ///// <param name="tableName">����</param>
        ///// <returns></returns>
        //public int GetId(string tableName)
        //{
        //    try
        //    {
        //        Stream stream = sqlMap.QueryForObject("GetStreamId", tableName) as Stream;
        //        return stream.IMaxID;
        //    }
        //    catch (Exception e)
        //    {
        //        throw (e);
        //    }
        //}

    }


    ///// <summary>
    ///// Stream 
    ///// </summary>
    //public class Stream
    //{
    //    public Stream()
    //    {

    //    }

    //    private string ctablename;

    //    public string CTableName
    //    {
    //        get { return ctablename; }
    //        set { ctablename = value; }
    //    }
    //    private int imaxid;

    //    public int IMaxID
    //    {
    //        get { return imaxid; }
    //        set { imaxid = value; }
    //    }
    //}

    //public class ContainerAccessorUtil
    //{
    //    private ContainerAccessorUtil()
    //    {
    //    }

    //    /// <summary>
    //    /// Obtain the Cuyahoga container.
    //    /// </summary>
    //    /// <returns></returns>
    //    public static IWindsorContainer GetContainer()
    //    {
    //        IContainerAccessor containerAccessor = HttpContext.Current.ApplicationInstance as IContainerAccessor;

    //        if (containerAccessor == null)
    //        {
    //            throw new Exception("You must extend the HttpApplication in your web project " +
    //                "and implement the IContainerAccessor to properly expose your container instance");
    //        }

    //        IWindsorContainer container = containerAccessor.Container as IWindsorContainer;

    //        if (container == null)
    //        {
    //            throw new Exception("The container seems to be unavailable in " +
    //                "your HttpApplication subclass");
    //        }

    //        return container;
    //    }
    //} 


}
