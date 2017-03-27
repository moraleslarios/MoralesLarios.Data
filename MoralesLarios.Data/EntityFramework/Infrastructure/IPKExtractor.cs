using System.Collections.Generic;

namespace MoralesLarios.Data.EntityFramework.Infrastructure
{
    public interface IPKExtractor
    {
        IEnumerable<object> ExtractPKInObjectEnumerable(object pk);
    }
}