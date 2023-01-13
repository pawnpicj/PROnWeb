using BarCodeLibrary.Respones.SAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarCodeAPIService.Service.MasterData
{
    public interface IEmployeeService
    {

        Task<ResponseGetEmployee> responseGetEmployee(string username, string passw0rd);

    }
}
