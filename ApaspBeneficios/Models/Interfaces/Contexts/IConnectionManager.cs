using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Models.Interfaces.Contexts
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }
}
