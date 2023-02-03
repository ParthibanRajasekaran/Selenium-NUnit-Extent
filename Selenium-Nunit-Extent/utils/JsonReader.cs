using System;
using Newtonsoft.Json.Linq;
using NUnit.Framework.Interfaces;

namespace selenium_nunit_extent.utils
{
	public class JsonReader
	{
		public JsonReader()
		{
		}

        public string? extractFromTestData(String tokenName)
        {
            var jsonData = File.ReadAllText("utils/testData.json");
            var token = JToken.Parse(jsonData).SelectToken(tokenName);
            return token != null ? token.Value<string>() : null;
        }

    }
}

