using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralesLarios.Data.Dapper.Infrastructure
{
    public interface IIDentityInspector<TEntity> where TEntity : class
    {
        string GetColumnsIdentityForType();
    }
}
