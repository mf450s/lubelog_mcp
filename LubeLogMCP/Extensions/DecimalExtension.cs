namespace LubeLogMCP.Extensions;
public static class DecimalExtensions
{
    public static string ToCommaString(this decimal value)
        => value.ToString(System.Globalization.CultureInfo.GetCultureInfo("de-DE"));
}