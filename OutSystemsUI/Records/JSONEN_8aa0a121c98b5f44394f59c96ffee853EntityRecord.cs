using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// AnimationType
public class JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord : AbstractRESTStructure<EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord> {
[JsonProperty("AnimationType")]
[JsonPropertyName("AnimationType")]
public string AttrAnimationType;

public JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord() { }

public JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord (EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAnimationType = s.ssAnimationType;
  } else {
AttrAnimationType = s.ssAnimationType;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord, EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord s) => ToStructure(s, config);
}
public static EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord s = new EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord();
  if(obj != null) {
  s.ssAnimationType = obj.AttrAnimationType == null ? "" : obj.AttrAnimationType;
  }
  return s;
}

public static Func<EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord FromStructure(EN_8aa0a121c98b5f44394f59c96ffee853EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_8aa0a121c98b5f44394f59c96ffee853EntityRecord(s, config);
}

}


