namespace VetmanagerPets
{
    internal static class Filter
    {
        public static string Get(string property, uint value)
        {
            return "?sort=[{'property':'id','direction':'ASC'}]&filter=[{'property':'" + property + "', 'value':" + value + ", 'operator':'='}]";
        }
    }
}
