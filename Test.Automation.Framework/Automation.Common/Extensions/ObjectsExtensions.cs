namespace Automation.Common.Extensions
{
    public static class ObjectsExtensions
    {
        public static Dictionary<string, string> GetNotNullObjectPropertiesDictionary<T>(this T entity)
        {
            var filledProperties = entity.GetType().GetProperties()
                .Where(p => p.GetValue(entity, null) != null).ToList();

            var propertyValuePairs = new Dictionary<string, string>();
            filledProperties.ForEach(p => propertyValuePairs.Add(p.Name, p.GetValue(entity, null).ToString()));
            return propertyValuePairs;
        }
    }
}
