using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// OptionalSearchPlacesConfigs
public class RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure : AbstractRESTStructure<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure> {
[JsonProperty("Countries")]
public RestList<string> AttrCountries;

[JsonProperty("SearchArea")]
public ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure AttrSearchArea;

[JsonProperty("SearchType")]
public string AttrSearchType;

[JsonProperty("Localization")]
public ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure AttrLocalization;

public RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure() { }

public RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCountries = s.ssCountries.Length == 0 ? null : s.ssCountries.ToRestList();
AttrSearchArea = ConvertToRestWithoutDefaults(s.ssSearchArea, new ST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure(), ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructureDelegate(config));
AttrSearchType = ConvertToRestWithoutDefaults(s.ssSearchType, "");
AttrLocalization = ConvertToRestWithoutDefaults(s.ssLocalization, new ST_59c2aa6a35b14343cc78f655810f9ce8Structure(), ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructureDelegate(config));
  } else {
AttrCountries = s.ssCountries.ToRestList();
AttrSearchArea = ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.FromStructure(s.ssSearchArea, config);
AttrSearchType = s.ssSearchType;
AttrLocalization = ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.FromStructure(s.ssLocalization, config);
  }
}

public static ST_7cd861eaa819851d6fba6d8150ed8cc1Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure obj) { 
  ST_7cd861eaa819851d6fba6d8150ed8cc1Structure s = new ST_7cd861eaa819851d6fba6d8150ed8cc1Structure();
  if(obj != null) {
  s.ssCountries = BasicTypeList<string>.FromRestList(obj.AttrCountries);
  s.ssSearchArea = ssOutSystemsMaps.RestRecords.RESTST_31cb630f5fdaa3aa4d3dbfd37cbf9e56Structure.ToStructure(obj.AttrSearchArea);
  s.ssSearchType = obj.AttrSearchType == null ? "" : obj.AttrSearchType;
  s.ssLocalization = ssOutSystemsMaps.RestRecords.RESTST_59c2aa6a35b14343cc78f655810f9ce8Structure.ToStructure(obj.AttrLocalization);
  }
  return s;
}

public static Func<ST_7cd861eaa819851d6fba6d8150ed8cc1Structure, ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7cd861eaa819851d6fba6d8150ed8cc1Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure FromStructure(ST_7cd861eaa819851d6fba6d8150ed8cc1Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_7cd861eaa819851d6fba6d8150ed8cc1Structure(s, config);
}

}


