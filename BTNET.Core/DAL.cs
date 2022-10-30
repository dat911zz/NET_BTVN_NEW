using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNET.Core
{
    public class DAL
    {
        private string connStr;
        //private delegate void Transaction();
        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }

        public DAL()
        {
            string svName = "";
            string dbName = "NET_QLSinhVien";
            ConnStr = GetConnectionString(svName, dbName);
        }
        public DAL(string svName, string dbName)
        {
            ConnStr = GetConnectionString(svName, dbName);
        }
        public string GetConnectionString(string svName, string dbName)
        {
            return "Data Source=" + svName + ";Initial Catalog=" + dbName + ";Integrated Security=True";
        }
        public int BeginTransaction(SqlCommand cmd, SqlParameter[] sqlParameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                cmd.Connection = conn;
                if (sqlParameters != null)
                {
                    cmd.Parameters.AddRange(sqlParameters);
                }
                return cmd.ExecuteNonQuery();
            }
        }
        //For create, update, delete
        public int Commit(string query)
        {
            return BeginTransaction(new SqlCommand(query));      
        }
        /// <summary>
        /// Query with parameters
        /// </summary>
        /// <param name="query"></param>
        /// <param name="sqlParameters"></param>
        /// For example:
        ///     new SqlParameter[]
        ///     {
        ///         new SqlParameter("@TaskID", SqlDbType.Int) { Value = (int)dr["BSTaskID"] },
        ///         new SqlParameter("@DateNow", SqlDbType.DateTime) { Value = DateTime.Now } ,
        ///         new SqlParameter("@ExecDate", SqlDbType.DateTime) { Value = execDate } ,
        ///         new SqlParameter("@UserId", SqlDbType.Int) { Value = (int)dr["BSUserId"] },
        ///         new SqlParameter("@TaskParameters", SqlDbType.VarChar) { Value = parametersXML }
        ///     });
        public void Commit(string query, SqlParameter[] sqlParameters)
        {
            BeginTransaction(new SqlCommand(query), sqlParameters);
        }
        ////For get data
        //public delegate List<T> GetData();

        //public List<object> Get()
        //{
        //    BeginTransaction
        //}
    }
}
