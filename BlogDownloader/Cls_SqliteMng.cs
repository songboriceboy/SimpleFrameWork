using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Common;
namespace BlogDownloader
{
    class Cls_SqliteMng
    {
        //string m_DBName = "";
        //string connStr = "";
       
        //创建一个数据库文件，保存在当前目录下HyData文件夹下
        //
        public void CreateDB(string dbName)
        {
           // string databaseFileName = System.Environment.CurrentDirectory + @"/HyData/" + dbName;

            SQLiteConnection.CreateFile(dbName);
        }

        //执行Sql语句
        //创建一个表：  ExecuteSql("create table HyTest(TestID TEXT)");
        //插入些数据：  ExecuteSql("insert into HyTest(TestID) values('1001')");
        public void ExecuteSql(string sqlStr, string strConStr)
        {
            //connStr = connStr1 + m_DBName + connStr;

            using (DbConnection conn = new SQLiteConnection(strConStr))
            {
                conn.Open();
                DbCommand comm = conn.CreateCommand();
                comm.CommandText = sqlStr;
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
            }
        }

      

        //执行查询返回DataSet
        private DataSet ExecDataSet(string sqlStr)
        {
            //connStr = "";
            //connStr = connStr1 + m_DBName + connStr;
            using (SQLiteConnection conn = new SQLiteConnection(sqlStr))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlStr;
                cmd.CommandType = CommandType.Text;

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
        }

    }
}
