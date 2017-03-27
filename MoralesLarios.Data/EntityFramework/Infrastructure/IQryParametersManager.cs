using System.Collections.Generic;

namespace MoralesLarios.Data.EntityFramework.Infrastructure
{
    public interface IQryParametersManager
    {
        Dictionary<string, object> GetParametersDictionary(object parameters);
        string GenerateStringQry(string qry, Dictionary<string, object> parameters);
    }
}