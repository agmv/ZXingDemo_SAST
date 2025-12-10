using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Marker
public class RESTST_5a7ef7acf3b11e0c41074aefa2466f75Structure : AbstractRESTStructure<ST_5a7ef7acf3b11e0c41074aefa2466f75Structure> {
[JsonProperty("Location")]
public string AttrLocation;

[JsonProperty("IconURL")]
public string AttrIconURL;

[JsonProperty("AdvancedFormat")]
public string AttrAdvancedFormat;

public RESTST_5a7ef7acf3b11e0c41074aefa2466f75Structure() { }

public RESTST_5a7ef7acf3b11e0c41074aefa2466f75Structure (ST_5a7ef7acf3b11e0c41074aefa2466f75Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLocation = ConvertToRestWithoutDefaults(s.ssLocation, "42.3517926,-71.0467845");
AttrIconURL = ConvertToRestWithoutDefaults(s.ssIconURL, "");
AttrAdvancedFormat = ConvertToRestWithoutDefaults(s.ssAdvancedFormat, "");
  } else {
AttrLocation = s.ssLocation;
AttrIconURL = s.ssIconURL;
AttrAdvancedFormat = s.ssAdvancedFormat;
  }
}

public static ST_5a7ef7acf3b11e0c41074aefa2466f75Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_5a7ef7acf3b11e0c41074aefa2466f75Structure obj) { 
  ST_5a7ef7acf3b11e0c41074aefa2466f75Structure s = new ST_5a7ef7acf3b11e0c41074aefa2466f75Structure();
  if(obj != null) {
  s.ssLocation = obj.AttrLocation == null ? "42.3517926,-71.0467845" : obj.AttrLocation;
  s.ssIconURL = obj.AttrIconURL == null ? "" : obj.AttrIconURL;
  s.ssAdvancedFormat = obj.AttrAdvancedFormat == null ? "" : obj.AttrAdvancedFormat;
  }
  return s;
}

public static Func<ST_5a7ef7acf3b11e0c41074aefa2466f75Structure, ssOutSystemsMaps.RestRecords.RESTST_5a7ef7acf3b11e0c41074aefa2466f75Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5a7ef7acf3b11e0c41074aefa2466f75Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_5a7ef7acf3b11e0c41074aefa2466f75Structure FromStructure(ST_5a7ef7acf3b11e0c41074aefa2466f75Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_5a7ef7acf3b11e0c41074aefa2466f75Structure(s, config);
}

}


