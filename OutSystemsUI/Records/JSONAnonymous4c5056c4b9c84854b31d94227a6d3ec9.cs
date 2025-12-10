using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerLanguageRecord
public class JSONRC_673cc0a63dbc3f5836f7732ba0712544 : AbstractRESTStructure<RC_673cc0a63dbc3f5836f7732ba0712544> {
[JsonProperty("DatePickerLanguage")]
[JsonPropertyName("DatePickerLanguage")]
public ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord AttrDatePickerLanguage;

public JSONRC_673cc0a63dbc3f5836f7732ba0712544() { }

public JSONRC_673cc0a63dbc3f5836f7732ba0712544 (RC_673cc0a63dbc3f5836f7732ba0712544 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerLanguage = ConvertToRestWithoutDefaults(s.ssENDatePickerLanguage, new EN_ac6f62956e278d5390a5f27c607338d0EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord.FromStructureDelegate(config));
  } else {
AttrDatePickerLanguage = ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord.FromStructure(s.ssENDatePickerLanguage, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_673cc0a63dbc3f5836f7732ba0712544, RC_673cc0a63dbc3f5836f7732ba0712544> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_673cc0a63dbc3f5836f7732ba0712544 s) => ToStructure(s, config);
}
public static RC_673cc0a63dbc3f5836f7732ba0712544 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_673cc0a63dbc3f5836f7732ba0712544 obj, IBehaviorsConfiguration config) { 
  RC_673cc0a63dbc3f5836f7732ba0712544 s = new RC_673cc0a63dbc3f5836f7732ba0712544();
  if(obj != null) {
  s.ssENDatePickerLanguage = ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord.ToStructure(obj.AttrDatePickerLanguage, config);
  }
  return s;
}

public static Func<RC_673cc0a63dbc3f5836f7732ba0712544, ssOutSystemsUI.RestRecords.JSONRC_673cc0a63dbc3f5836f7732ba0712544> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_673cc0a63dbc3f5836f7732ba0712544 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_673cc0a63dbc3f5836f7732ba0712544 FromStructure(RC_673cc0a63dbc3f5836f7732ba0712544 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_673cc0a63dbc3f5836f7732ba0712544(s, config);
}

}


