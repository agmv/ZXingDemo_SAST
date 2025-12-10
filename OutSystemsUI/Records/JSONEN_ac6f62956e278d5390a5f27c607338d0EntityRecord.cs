using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerLanguage
public class JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord : AbstractRESTStructure<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord> {
[JsonProperty("Alpha2Code")]
[JsonPropertyName("Alpha2Code")]
public string AttrAlpha2Code;

[JsonProperty("LanguageName")]
[JsonPropertyName("LanguageName")]
public string AttrLanguageName;

public JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord() { }

public JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAlpha2Code = s.ssAlpha2Code;
AttrLanguageName = s.ssLanguageName;
  } else {
AttrAlpha2Code = s.ssAlpha2Code;
AttrLanguageName = s.ssLanguageName;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord, EN_ac6f62956e278d5390a5f27c607338d0EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord s) => ToStructure(s, config);
}
public static EN_ac6f62956e278d5390a5f27c607338d0EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_ac6f62956e278d5390a5f27c607338d0EntityRecord s = new EN_ac6f62956e278d5390a5f27c607338d0EntityRecord();
  if(obj != null) {
  s.ssAlpha2Code = obj.AttrAlpha2Code == null ? "" : obj.AttrAlpha2Code;
  s.ssLanguageName = obj.AttrLanguageName == null ? "" : obj.AttrLanguageName;
  }
  return s;
}

public static Func<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord FromStructure(EN_ac6f62956e278d5390a5f27c607338d0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_ac6f62956e278d5390a5f27c607338d0EntityRecord(s, config);
}

}


