using System.Collections.Generic;

namespace ProGet.Net.Common
{
    public static class QueryParamValues
    {
        public static IDictionary<string, object> From(params NamedValue[] namedValues)
        {
            var result = new Dictionary<string, object>();
            foreach (var namedValue in namedValues)
            {
                result[namedValue.Name] = namedValue.Value;
            }

            return result;
        }
    }
}
