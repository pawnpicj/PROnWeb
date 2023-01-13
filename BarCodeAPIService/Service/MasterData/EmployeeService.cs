using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarCodeAPIService.Connection;
using BarCodeLibrary.Respones.SAP;
using SAPbobsCOM;
using BarCodeAPIService.Models;
using System.Globalization;
using System.Data;
using System.Data.Odbc;

namespace BarCodeAPIService.Service.MasterData
{
    public class EmployeeService : IEmployeeService
    {
        public Task<ResponseGetEmployee> responseGetEmployee(string username, string passw0rd)
        {
            var dataLine = new List<ListEmp>();
            var dt = new DataTable();

            try
            {
                var login = new LoginOnlyDatabase(LoginOnlyDatabase.Type.SapHana);
                if (login.lErrCode == 0)
                {

                    var Query = $"CALL \"{ConnectionString.CompanyDB}\"._USP_CALLTRANS_MASTERDATA('GetEmployee','{username}','{passw0rd}','','','')";
                    login.AD = new OdbcDataAdapter(Query, login.CN);
                    login.AD.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        dataLine.Add(new ListEmp
                        {
                            EmpId = row["EmpId"].ToString()
                            , FirstName = row["FirstName"].ToString()
                            , LastName = row["LastName"].ToString()
                            , Email = row["Email"].ToString()                            
                            , Position = row["Position"].ToString()
                            //, Passw0rd = row["Passw0rd"].ToString()
                        });
                    }
                    return Task.FromResult(new ResponseGetEmployee
                    {
                        ErrorCode = 0,
                        ErrorMsg = "",
                        Data = dataLine.ToList()
                    });
                }

                return Task.FromResult(new ResponseGetEmployee
                {
                    ErrorCode = login.lErrCode,
                    ErrorMsg = login.sErrMsg,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                return Task.FromResult(new ResponseGetEmployee
                {
                    ErrorCode = ex.HResult,
                    ErrorMsg = ex.Message,
                    Data = null
                });
            }
        }
    }
}
