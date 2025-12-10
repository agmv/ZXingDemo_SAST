using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Internal_to_provider_searchPlaces_configs
public class RESTST_d4721898ae8c007cd938074f575e2979Structure : AbstractRESTStructure<ST_d4721898ae8c007cd938074f575e2979Structure> {
[JsonProperty("apiKey")]
public string AttrapiKey;

[JsonProperty("countries")]
public RestList<string> Attrcountries;

[JsonProperty("searchArea")]
public ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure AttrsearchArea;

[JsonProperty("searchType")]
public string AttrsearchType;

[JsonProperty("localization")]
public ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure Attrlocalization;

public RESTST_d4721898ae8c007cd938074f575e2979Structure() { }

public RESTST_d4721898ae8c007cd938074f575e2979Structure (ST_d4721898ae8c007cd938074f575e2979Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrapiKey = s.ssapiKey;
Attrcountries = s.sscountries.Length == 0 ? null : s.sscountries.ToRestList();
AttrsearchArea = ConvertToRestWithoutDefaults(s.sssearchArea, new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure(), ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructureDelegate(config));
AttrsearchType = ConvertToRestWithoutDefaults(s.sssearchType, "");
Attrlocalization = ConvertToRestWithoutDefaults(s.sslocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
  } else {
AttrapiKey = s.ssapiKey;
Attrcountries = s.sscountries.ToRestList();
AttrsearchArea = ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructure(s.sssearchArea, config);
AttrsearchType = s.sssearchType;
Attrlocalization = ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.sslocalization, config);
  }
}

public static ST_d4721898ae8c007cd938074f575e2979Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_d4721898ae8c007cd938074f575e2979Structure obj) { 
  ST_d4721898ae8c007cd938074f575e2979Structure s = new ST_d4721898ae8c007cd938074f575e2979Structure();
  if(obj != null) {
  s.ssapiKey = obj.AttrapiKey == null ? "" : obj.AttrapiKey;
  s.sscountries = BasicTypeList<string>.FromRestList(obj.Attrcountries);
  s.sssearchArea = ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.ToStructure(obj.AttrsearchArea);
  s.sssearchType = obj.AttrsearchType == null ? "" : obj.AttrsearchType;
  s.sslocalization = ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.Attrlocalization);
  }
  return s;
}

public static Func<ST_d4721898ae8c007cd938074f575e2979Structure, ssOutSystemsMaps.RestRecords.RESTST_d4721898ae8c007cd938074f575e2979Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_d4721898ae8c007cd938074f575e2979Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_d4721898ae8c007cd938074f575e2979Structure FromStructure(ST_d4721898ae8c007cd938074f575e2979Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_d4721898ae8c007cd938074f575e2979Structure(s, config);
}

}


