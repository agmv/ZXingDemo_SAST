using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsMaps.RestRecords;

// Author
public class RESTST_44bc2bbbb8592f02bc88a9fdf25bb951Structure : AbstractRESTStructure<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> {
[JsonProperty("Email")]
public string AttrEmail;

[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Uri")]
public string AttrUri;

public RESTST_44bc2bbbb8592f02bc88a9fdf25bb951Structure() { }

public RESTST_44bc2bbbb8592f02bc88a9fdf25bb951Structure (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s, IBehaviorsConfiguration config) {
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

public static ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure ToStructure(ssOutSystemsMaps.RestRecords.RESTST_44bc2bbbb8592f02bc88a9fdf25bb951Structure obj) { 
  ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s = new ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure();
  if(obj != null) {
  s.ssEmail = obj.AttrEmail == null ? "" : obj.AttrEmail;
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssUri = obj.AttrUri == null ? "" : obj.AttrUri;
  }
  return s;
}

public static Func<ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure, ssOutSystemsMaps.RestRecords.RESTST_44bc2bbbb8592f02bc88a9fdf25bb951Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s) => FromStructure(s, config);
}
public static ssOutSystemsMaps.RestRecords.RESTST_44bc2bbbb8592f02bc88a9fdf25bb951Structure FromStructure(ST_44bc2bbbb8592f02bc88a9fdf25bb951Structure s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsMaps.RestRecords.RESTST_44bc2bbbb8592f02bc88a9fdf25bb951Structure(s, config);
}

}


