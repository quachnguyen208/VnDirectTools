using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace IntegrationEndPoint.GlobalClass
{
    public class ConnectionClass<T>
    {
        //ConfigurationManager
        public string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["BI"].ConnectionString;
        public IEnumerable<T> GetData(string storeName, Dictionary<string, string> keywords)
        {

            DynamicParameters parameters = new DynamicParameters();
            if (keywords.Count() > 0)
            {
                foreach (var keyword in keywords)
                {
                    parameters.Add(keyword.Key, keyword.Value, DbType.String, ParameterDirection.Input, 200);
                }
            }
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    var result = connection.Query<T>(storeName, parameters, commandType: CommandType.StoredProcedure).ToList();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally { connection.Close(); }
            }
        }
    }
}
