using System.Reflection;
using SkolmatenApi.Attributes;

namespace SkolmatenApi.Types.UrlParameters;

public class UrlParameters
{
    public string ToUrl()
    {
        string result = "";
        
        List<PropertyInfo> properties = GetPropertiesWithUrlParameterAttribute().ToList();
        
        for (int i = 0; i < properties.Count(); i++)
        {
            PropertyInfo property = properties.ElementAt(i);
            string customName = property.GetCustomAttribute<UrlParameterAttribute>()!.Name;
            var value = property.GetValue(this);
            
            if (value == null)
                continue;
            
            if (i <= 0)
                result += "?";
            else
                result += "&";

            result += $"{customName}={value}";
        }

        return result;
    }
    
    private IEnumerable<PropertyInfo> GetPropertiesWithUrlParameterAttribute()
    {
        return GetType()
            .GetProperties()
            .Where(p => p.GetCustomAttribute<UrlParameterAttribute>() != null);
    }
}