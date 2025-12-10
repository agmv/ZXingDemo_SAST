using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DatePickerProvider
public class JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord : AbstractRESTStructure<EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord> {
[JsonProperty("Provider")]
[JsonPropertyName("Provider")]
public string AttrProvider;

public JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord() { }

public JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord (EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProvider = s.ssProvider;
  } else {
AttrProvider = s.ssProvider;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord, EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord s) => ToStructure(s, config);
}
public static EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord s = new EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord();
  if(obj != null) {
  s.ssProvider = obj.AttrProvider == null ? "" : obj.AttrProvider;
  }
  return s;
}

public static Func<EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord FromStructure(EN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_3a1bf32d2ff94c720f1efbdad7281777EntityRecord(s, config);
}

}


