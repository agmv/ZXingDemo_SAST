using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// Gradient
public class JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord : AbstractRESTStructure<EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord> {
[JsonProperty("Type")]
[JsonPropertyName("Type")]
public string AttrType;

public JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord() { }

public JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord (EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrType = s.ssType;
  } else {
AttrType = s.ssType;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord, EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord s) => ToStructure(s, config);
}
public static EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord s = new EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord();
  if(obj != null) {
  s.ssType = obj.AttrType == null ? "" : obj.AttrType;
  }
  return s;
}

public static Func<EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord FromStructure(EN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_f318de02ad2d00bca70ecb5d73f27ec9EntityRecord(s, config);
}

}


