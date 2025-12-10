using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Stroke
public class RESTST_c2a46cf64d2acc4b38d805712495224cStructure : AbstractRESTStructure<ST_c2a46cf64d2acc4b38d805712495224cStructure> {
[JsonProperty("Color")]
public string AttrColor;

[JsonProperty("Opacity")]
public decimal? AttrOpacity;

[JsonProperty("Weight")]
public int? AttrWeight;

public RESTST_c2a46cf64d2acc4b38d805712495224cStructure() { }

public RESTST_c2a46cf64d2acc4b38d805712495224cStructure (ST_c2a46cf64d2acc4b38d805712495224cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = ConvertToRestWithoutDefaults(s.ssColor, "#000000");
AttrOpacity = ConvertToRestWithoutDefaults(s.ssOpacity, (((decimal)1)));
AttrWeight = ConvertToRestWithoutDefaults(s.ssWeight, 2);
  } else {
AttrColor = s.ssColor;
AttrOpacity = (decimal?) s.ssOpacity;
AttrWeight = (int?) s.ssWeight;
  }
}

public static ST_c2a46cf64d2acc4b38d805712495224cStructure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure obj) { 
  ST_c2a46cf64d2acc4b38d805712495224cStructure s = new ST_c2a46cf64d2acc4b38d805712495224cStructure();
  if(obj != null) {
  s.ssColor = obj.AttrColor == null ? "#000000" : obj.AttrColor;
  s.ssOpacity = obj.AttrOpacity == null ? (((decimal)1)) : obj.AttrOpacity.Value;
  s.ssWeight = obj.AttrWeight == null ? 2 : obj.AttrWeight.Value;
  }
  return s;
}

public static Func<ST_c2a46cf64d2acc4b38d805712495224cStructure, ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c2a46cf64d2acc4b38d805712495224cStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure FromStructure(ST_c2a46cf64d2acc4b38d805712495224cStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_c2a46cf64d2acc4b38d805712495224cStructure(s, config);
}

}


