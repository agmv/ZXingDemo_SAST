using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalSearchPlacesConfigs
public class JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure : AbstractRESTStructure<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure> {
[JsonProperty("Countries")]
[JsonPropertyName("Countries")]
public string[] AttrCountries;

[JsonProperty("SearchArea")]
[JsonPropertyName("SearchArea")]
public ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure AttrSearchArea;

[JsonProperty("SearchType")]
[JsonPropertyName("SearchType")]
public string AttrSearchType;

[JsonProperty("Localization")]
[JsonPropertyName("Localization")]
public ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure AttrLocalization;

public JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure() { }

public JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCountries = s.ssCountries.Length == 0 ? null : s.ssCountries.ToArray();
AttrSearchArea = ConvertToRestWithoutDefaults(s.ssSearchArea, new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure(), ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructureDelegate(config));
AttrSearchType = ConvertToRestWithoutDefaults(s.ssSearchType, "");
AttrLocalization = ConvertToRestWithoutDefaults(s.ssLocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
  } else {
AttrCountries = s.ssCountries.ToArray();
AttrSearchArea = ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructure(s.ssSearchArea, config);
AttrSearchType = s.ssSearchType;
AttrLocalization = ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.ssLocalization, config);
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure, ST_7cd861eaa819851d6fba6d8150ed8cc1Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure s) => ToStructure(s, config);
}
public static ST_7cd861eaa819851d6fba6d8150ed8cc1Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure obj, IBehaviorsConfiguration config) { 
  ST_7cd861eaa819851d6fba6d8150ed8cc1Structure s = new ST_7cd861eaa819851d6fba6d8150ed8cc1Structure();
  if(obj != null) {
  s.ssCountries = BasicTypeList<string>.ToList(obj.AttrCountries);
  s.ssSearchArea = ssOutSystemsMaps.RestRecords.JSONST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.ToStructure(obj.AttrSearchArea, config);
  s.ssSearchType = obj.AttrSearchType == null ? "" : obj.AttrSearchType;
  s.ssLocalization = ssOutSystemsMaps.RestRecords.JSONST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.AttrLocalization, config);
  }
  return s;
}

public static Func<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure, ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure FromStructure(ST_7cd861eaa819851d6fba6d8150ed8cc1Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_7cd861eaa819851d6fba6d8150ed8cc1Structure(s, config);
}

}


