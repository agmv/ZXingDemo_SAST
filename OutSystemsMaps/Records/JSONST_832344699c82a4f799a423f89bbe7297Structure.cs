using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// StaticMarker
public class JSONST_832344699c82a4f799a423f89bbe7297Structure : AbstractRESTStructure<ST_832344699c82a4f799a423f89bbe7297Structure> {
[JsonProperty("location")]
[JsonPropertyName("location")]
public string AttrLocation;

[JsonProperty("iconUrl")]
[JsonPropertyName("iconUrl")]
public string AttrIconURL;

[JsonProperty("advancedFormat")]
[JsonPropertyName("advancedFormat")]
public string AttrDEPRECATED_AdvancedFormat;

public JSONST_832344699c82a4f799a423f89bbe7297Structure() { }

public JSONST_832344699c82a4f799a423f89bbe7297Structure (ST_832344699c82a4f799a423f89bbe7297Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLocation = ConvertToRestWithoutDefaults(s.ssLocation, "42.3517926,-71.0467845");
AttrIconURL = ConvertToRestWithoutDefaults(s.ssIconURL, "");
AttrDEPRECATED_AdvancedFormat = ConvertToRestWithoutDefaults(s.ssDEPRECATED_AdvancedFormat, "");
  } else {
AttrLocation = s.ssLocation;
AttrIconURL = s.ssIconURL;
AttrDEPRECATED_AdvancedFormat = s.ssDEPRECATED_AdvancedFormat;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure, ST_832344699c82a4f799a423f89bbe7297Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure s) => ToStructure(s, config);
}
public static ST_832344699c82a4f799a423f89bbe7297Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure obj, IBehaviorsConfiguration config) { 
  ST_832344699c82a4f799a423f89bbe7297Structure s = new ST_832344699c82a4f799a423f89bbe7297Structure();
  if(obj != null) {
  s.ssLocation = obj.AttrLocation == null ? "42.3517926,-71.0467845" : obj.AttrLocation;
  s.ssIconURL = obj.AttrIconURL == null ? "" : obj.AttrIconURL;
  s.ssDEPRECATED_AdvancedFormat = obj.AttrDEPRECATED_AdvancedFormat == null ? "" : obj.AttrDEPRECATED_AdvancedFormat;
  }
  return s;
}

public static Func<ST_832344699c82a4f799a423f89bbe7297Structure, ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_832344699c82a4f799a423f89bbe7297Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure FromStructure(ST_832344699c82a4f799a423f89bbe7297Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_832344699c82a4f799a423f89bbe7297Structure(s, config);
}

}


