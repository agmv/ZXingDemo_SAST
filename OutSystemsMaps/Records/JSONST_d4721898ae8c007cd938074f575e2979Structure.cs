using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_searchPlaces_configs
public class JSONST_d4721898ae8c007cd938074f575e2979Structure : AbstractRESTStructure<ST_d4721898ae8c007cd938074f575e2979Structure> {
[JsonProperty("apiKey")]
[JsonPropertyName("apiKey")]
public string AttrapiKey;

[JsonProperty("countries")]
[JsonPropertyName("countries")]
public string[] Attrcountries;

[JsonProperty("searchArea")]
[JsonPropertyName("searchArea")]
public ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure AttrsearchArea;

[JsonProperty("searchType")]
[JsonPropertyName("searchType")]
public string AttrsearchType;

[JsonProperty("localization")]
[JsonPropertyName("localization")]
public ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure Attrlocalization;

public JSONST_d4721898ae8c007cd938074f575e2979Structure() { }

public JSONST_d4721898ae8c007cd938074f575e2979Structure (ST_d4721898ae8c007cd938074f575e2979Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrapiKey = s.ssapiKey;
Attrcountries = s.sscountries.Length == 0 ? null : s.sscountries.ToArray();
AttrsearchArea = ConvertToRestWithoutDefaults(s.sssearchArea, new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure(), ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructureDelegate(config));
AttrsearchType = ConvertToRestWithoutDefaults(s.sssearchType, "");
Attrlocalization = ConvertToRestWithoutDefaults(s.sslocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
  } else {
AttrapiKey = s.ssapiKey;
Attrcountries = s.sscountries.ToArray();
AttrsearchArea = ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructure(s.sssearchArea, config);
AttrsearchType = s.sssearchType;
Attrlocalization = ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.sslocalization, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure, ST_d4721898ae8c007cd938074f575e2979Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure s) => ToStructure(s, config);
}
public static ST_d4721898ae8c007cd938074f575e2979Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure obj, IBehaviorsConfiguration config) { 
  ST_d4721898ae8c007cd938074f575e2979Structure s = new ST_d4721898ae8c007cd938074f575e2979Structure();
  if(obj != null) {
  s.ssapiKey = obj.AttrapiKey == null ? "" : obj.AttrapiKey;
  s.sscountries = BasicTypeList<string>.ToList(obj.Attrcountries);
  s.sssearchArea = ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.ToStructure(obj.AttrsearchArea, config);
  s.sssearchType = obj.AttrsearchType == null ? "" : obj.AttrsearchType;
  s.sslocalization = ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.Attrlocalization, config);
  }
  return s;
}

public static Func<ST_d4721898ae8c007cd938074f575e2979Structure, ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d4721898ae8c007cd938074f575e2979Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure FromStructure(ST_d4721898ae8c007cd938074f575e2979Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_d4721898ae8c007cd938074f575e2979Structure(s, config);
}

}


