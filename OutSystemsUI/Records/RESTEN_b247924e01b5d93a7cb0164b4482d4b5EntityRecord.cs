using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// RangeSliderProvider
public class RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord : AbstractRESTStructure<EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord> {
[JsonProperty("Provider")]
public string AttrProvider;

public RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord() { }

public RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord (EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProvider = s.ssProvider;
  } else {
AttrProvider = s.ssProvider;
  }
}

public static EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord obj) { 
  EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s = new EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord();
  if(obj != null) {
  s.ssProvider = obj.AttrProvider == null ? "" : obj.AttrProvider;
  }
  return s;
}

public static Func<EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord, ssOutSystemsUI.RestRecords.RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord FromStructure(EN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_b247924e01b5d93a7cb0164b4482d4b5EntityRecord(s, config);
}

}


