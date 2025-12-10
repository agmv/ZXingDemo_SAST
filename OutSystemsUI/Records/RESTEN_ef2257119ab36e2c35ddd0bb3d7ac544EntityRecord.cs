using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ColumnBreak
public class RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord : AbstractRESTStructure<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> {
[JsonProperty("ColumnBreak")]
public string AttrColumnBreak;

public RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord() { }

public RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrColumnBreak = s.ssColumnBreak;
  } else {
AttrColumnBreak = s.ssColumnBreak;
  }
}

public static EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord obj) { 
  EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s = new EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord();
  if(obj != null) {
  s.ssColumnBreak = obj.AttrColumnBreak == null ? "" : obj.AttrColumnBreak;
  }
  return s;
}

public static Func<EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord FromStructure(EN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_ef2257119ab36e2c35ddd0bb3d7ac544EntityRecord(s, config);
}

}


