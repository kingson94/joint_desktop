using System.Text.Json;
using Newtonsoft.Json.Linq;

public static class Util
{
    public static int JsonFromFile(string strJsonPath, ref JObject obJson)
    {
        try
        {
            string strJsonData = System.IO.File.ReadAllText(strJsonPath);
            obJson = JObject.Parse(strJsonData);
        }
        catch (System.Exception ex)
        {
            return 1;
        }

        return 0;
    }

    public static string JsonToString(JObject obJson)
    {
        return JsonToString(obJson, false);
    }
    
    public static string JsonToString(JObject obJson, bool bIsIndent)
    {
        string strJsonData = "";

        try
        {
            Newtonsoft.Json.Formatting jFormatOption = Newtonsoft.Json.Formatting.None;
            if (bIsIndent)
            {
                jFormatOption = Newtonsoft.Json.Formatting.Indented;
            }

            strJsonData = obJson.ToString(jFormatOption);
        }
        catch (System.Exception ex)
        {
            return "";
        }
        
        return strJsonData;
    }
}