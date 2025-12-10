using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// StaticMarker
public class RESTST_832344699c82a4f799a423f89bbe7297Structure : AbstractRESTStructure<ST_832344699c82a4f799a423f89bbe7297Structure> {
[JsonProperty("Location")]
public string AttrLocation;

[JsonProperty("IconURL")]
public string AttrIconURL;

[JsonProperty("DEPRECATED_AdvancedFormat")]
public string AttrDEPRECATED_AdvancedFormat;

public RESTST_832344699c82a4f799a423f89bbe7297Structure() { }

public RESTST_832344699c82a4f799a423f89bbe7297Structure (ST_832344699c82a4f799a423f89bbe7297Structure s, IBehaviorsConfiguration config) {
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

public static ST_832344699c82a4f799a423f89bbe7297Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_832344699c82a4f799a423f89bbe7297Structure obj) { 
  ST_832344699c82a4f799a423f89bbe7297Structure s = new ST_832344699c82a4f799a423f89bbe7297Structure();
  if(obj != null) {
  s.ssLocation = obj.AttrLocation == null ? "42.3517926,-71.0467845" : obj.AttrLocation;
  s.ssIconURL = obj.AttrIconURL == null ? "" : obj.AttrIconURL;
  s.ssDEPRECATED_AdvancedFormat = obj.AttrDEPRECATED_AdvancedFormat == null ? "" : obj.AttrDEPRECATED_AdvancedFormat;
  }
  return s;
}

public static Func<ST_832344699c82a4f799a423f89bbe7297Structure, ssOutSystemsMaps.RestRecords.RESTST_832344699c82a4f799a423f89bbe7297Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_832344699c82a4f799a423f89bbe7297Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_832344699c82a4f799a423f89bbe7297Structure FromStructure(ST_832344699c82a4f799a423f89bbe7297Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_832344699c82a4f799a423f89bbe7297Structure(s, config);
}

}


