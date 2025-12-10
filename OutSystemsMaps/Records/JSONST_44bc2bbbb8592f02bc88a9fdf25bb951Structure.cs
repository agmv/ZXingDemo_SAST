using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Author
public class JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure : AbstractRESTStructure<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> {
[JsonProperty("email")]
[JsonPropertyName("email")]
public string AttrEmail;

[JsonProperty("name")]
[JsonPropertyName("name")]
public string AttrName;

[JsonProperty("uri")]
[JsonPropertyName("uri")]
public string AttrUri;

public JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure() { }

public JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEmail = ConvertToRestWithoutDefaults(s.ssEmail, "");
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrUri = ConvertToRestWithoutDefaults(s.ssUri, "");
  } else {
AttrEmail = s.ssEmail;
AttrName = s.ssName;
AttrUri = s.ssUri;
  }
}

public static Func<ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure, ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s) => ToStructure(s, config);
}
public static ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure ToStructure(ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure obj, IBehaviorsConfiguration config) { 
  ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s = new ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure();
  if(obj != null) {
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssUri = obj.AttrUri == null ? "" : obj.AttrUri;
  }
  return s;
}

public static Func<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure, ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure FromStructure(ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.JSONST_44bc2bbbb8592f02bc88a9fdf25bb951Structure(s, config);
}

}


