using Dapper;
using Microsoft.Extensions.Configuration;
using MyTodoist.Data;
using MyTodoist.IService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyTodoist.Service
{
    public class UserRegistrationService : IUserRegistrationService
    {
        public IConfiguration _Configuration { get; }
        public string _ConnString = "";
        public UserRegistrationService(IConfiguration configuration)
        {
            _Configuration = configuration;
            _ConnString = _Configuration.GetConnectionString("DevDB");
        }
        public async Task<bool> SaveUserRegistration(UserRegistration userRegistration)
        {
            var parameters = new DynamicParameters();
            parameters.Add("FirstName", userRegistration.FirstName, DbType.String);
            parameters.Add("LastName", userRegistration.LastName, DbType.String);
            parameters.Add("EmailId", userRegistration.EmailId, DbType.String);

            using (IDbConnection con = new SqlConnection(_ConnString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    await con.ExecuteAsync("[Users].[pSaveUserRegistration]", parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                }
            }
            return true;
        }
    }
}
