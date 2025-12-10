using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ColumnBreak
public class JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord : AbstractRESTStructure<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> {
[JsonProperty("ColumnBreak")]
[JsonPropertyName("ColumnBreak")]
public string AttrColumnBreak;

public JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord() { }

public JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColumnBreak = s.ssColumnBreak;
  } else {
AttrColumnBreak = s.ssColumnBreak;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord, EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s) => ToStructure(s, config);
}
public static EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s = new EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord();
  if(obj != null) {
  s.ssColumnBreak = obj.AttrColumnBreak == null ? "" : obj.AttrColumnBreak;
  }
  return s;
}

public static Func<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord FromStructure(EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord(s, config);
}

}


