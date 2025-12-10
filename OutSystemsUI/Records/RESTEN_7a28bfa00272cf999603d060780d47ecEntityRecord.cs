using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownType
public class RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord : AbstractRESTStructure<EN_7a28bfa00272cf999603d060780d47ecEntityRecord> {
[JsonProperty("Mode")]
public string AttrMode;

public RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord() { }

public RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord (EN_7a28bfa00272cf999603d060780d47ecEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrMode = s.ssMode;
  } else {
AttrMode = s.ssMode;
  }
}

public static EN_7a28bfa00272cf999603d060780d47ecEntityRecord ToStructure(ssOutSystemsUI.RestRecords.RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord obj) { 
  EN_7a28bfa00272cf999603d060780d47ecEntityRecord s = new EN_7a28bfa00272cf999603d060780d47ecEntityRecord();
  if(obj != null) {
  s.ssMode = obj.AttrMode == null ? "" : obj.AttrMode;
  }
  return s;
}

public static Func<EN_7a28bfa00272cf999603d060780d47ecEntityRecord, ssOutSystemsUI.RestRecords.RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7a28bfa00272cf999603d060780d47ecEntityRecord s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord FromStructure(EN_7a28bfa00272cf999603d060780d47ecEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord(s, config);
}

}


