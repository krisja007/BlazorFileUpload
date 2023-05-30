using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        //Show Data in Query//
        public async Task<List<T>> LoadData<T, U>(string sql, U Parameters, string conectionString)
        {
            using (IDbConnection connection = new MySqlConnection(conectionString))
            {
                var  row = await connection.QueryAsync<T>(sql, Parameters);

                return row.ToList();
            }
        }

        // Save Data and Execute//
        public Task SaveData<T>(string sql, T Parameters, string conectionString)
        {
            using (IDbConnection connection = new MySqlConnection(conectionString))
            {
                return connection.ExecuteAsync(sql, Parameters);
            }
        }

    }
}
