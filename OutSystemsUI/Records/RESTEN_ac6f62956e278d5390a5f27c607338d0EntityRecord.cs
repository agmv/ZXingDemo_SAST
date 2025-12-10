using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerLanguage
public class RESTEN_ac6f62956e278d5390a5f27c607338d0EntityRecord : AbstractRESTStructure<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord> {
[JsonProperty("Alpha2Code")]
public string AttrAlpha2Code;

[JsonProperty("LanguageName")]
public string AttrLanguageName;

public RESTEN_ac6f62956e278d5390a5f27c607338d0EntityRecord() { }

public RESTEN_ac6f62956e278d5390a5f27c607338d0EntityRecord (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAlpha2Code = s.ssAlpha2Code;
AttrLanguageName = s.ssLanguageName;
  } else {
AttrAlpha2Code = s.ssAlpha2Code;
AttrLanguageName = s.ssLanguageName;
  }
}

public static EN_ac6f62956e278d5390a5f27c607338d0EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_ac6f62956e278d5390a5f27c607338d0EntityRecord obj) { 
  EN_ac6f62956e278d5390a5f27c607338d0EntityRecord s = new EN_ac6f62956e278d5390a5f27c607338d0EntityRecord();
  if(obj != null) {
  s.ssAlpha2Code = obj.AttrAlpha2Code == null ? "" : obj.AttrAlpha2Code;
  s.ssLanguageName = obj.AttrLanguageName == null ? "" : obj.AttrLanguageName;
  }
  return s;
}

public static Func<EN_ac6f62956e278d5390a5f27c607338d0EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_ac6f62956e278d5390a5f27c607338d0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_ac6f62956e278d5390a5f27c607338d0EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_ac6f62956e278d5390a5f27c607338d0EntityRecord FromStructure(EN_ac6f62956e278d5390a5f27c607338d0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_ac6f62956e278d5390a5f27c607338d0EntityRecord(s, config);
}

}


