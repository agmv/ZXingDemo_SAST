using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSliderProvider
public class JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord : AbstractRESTStructure<EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord> {
[JsonProperty("Provider")]
[JsonPropertyName("Provider")]
public string AttrProvider;

public JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord() { }

public JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord (EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProvider = s.ssProvider;
  } else {
AttrProvider = s.ssProvider;
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord, EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s) => ToStructure(s, config);
}
public static EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord ToStructure(ssOutSystemsUI.RestRecords.JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s = new EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord();
  if(obj != null) {
  s.ssProvider = obj.AttrProvider == null ? "" : obj.AttrProvider;
  }
  return s;
}

public static Func<EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord, ssOutSystemsUI.RestRecords.JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord FromStructure(EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord(s, config);
}

}


