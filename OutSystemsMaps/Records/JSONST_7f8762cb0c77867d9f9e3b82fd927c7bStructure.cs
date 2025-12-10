using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Fill
public class JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure : AbstractRESTStructure<ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure> {
[JsonProperty("Color")]
[JsonPropertyName("Color")]
public string AttrColor;

[JsonProperty("Opacity")]
[JsonPropertyName("Opacity")]
public decimal? AttrOpacity;

public JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure() { }

public JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColor = ConvertToRestWithoutDefaults(s.ssColor, "#000000");
AttrOpacity = ConvertToRestWithoutDefaults(s.ssOpacity, (((decimal)1)));
  } else {
AttrColor = s.ssColor;
AttrOpacity = (decimal?) s.ssOpacity;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure, ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure s) => ToStructure(s, config);
}
public static ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure obj, IBehaviorsConfiguration config) { 
  ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure s = new ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure();
  if(obj != null) {
  s.ssColor = obj.AttrColor == null ? "#000000" : obj.AttrColor;
  s.ssOpacity = obj.AttrOpacity == null ? (((decimal)1)) : obj.AttrOpacity.Value;
  }
  return s;
}

public static Func<ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure, ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure FromStructure(ST_7f8762cb0c77867d9f9e3b82fd927c7bStructure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_7f8762cb0c77867d9f9e3b82fd927c7bStructure(s, config);
}

}


