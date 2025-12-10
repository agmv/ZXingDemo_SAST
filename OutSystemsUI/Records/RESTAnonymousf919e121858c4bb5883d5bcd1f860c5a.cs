using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// DropdownTypeRecord
public class RESTRC_7f56ea63061432843ab4dd16f4578b32 : AbstractRESTStructure<RC_7f56ea63061432843ab4dd16f4578b32> {
[JsonProperty("DropdownType")]
public ssOutSystemsUI.RestRecords.RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord AttrDropdownType;

public RESTRC_7f56ea63061432843ab4dd16f4578b32() { }

public RESTRC_7f56ea63061432843ab4dd16f4578b32 (RC_7f56ea63061432843ab4dd16f4578b32 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownType = ConvertToRestWithoutDefaults(s.ssENDropdownType, new EN_7a28bfa00272cf999603d060780d47ecEntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord.FromStructureDelegate(config));
  } else {
AttrDropdownType = ssOutSystemsUI.RestRecords.RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord.FromStructure(s.ssENDropdownType, config);
  }
}

public static RC_7f56ea63061432843ab4dd16f4578b32 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_7f56ea63061432843ab4dd16f4578b32 obj) { 
  RC_7f56ea63061432843ab4dd16f4578b32 s = new RC_7f56ea63061432843ab4dd16f4578b32();
  if(obj != null) {
  s.ssENDropdownType = ssOutSystemsUI.RestRecords.RESTEN_7a28bfa00272cf999603d060780d47ecEntityRecord.ToStructure(obj.AttrDropdownType);
  }
  return s;
}

public static Func<RC_7f56ea63061432843ab4dd16f4578b32, ssOutSystemsUI.RestRecords.RESTRC_7f56ea63061432843ab4dd16f4578b32> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7f56ea63061432843ab4dd16f4578b32 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_7f56ea63061432843ab4dd16f4578b32 FromStructure(RC_7f56ea63061432843ab4dd16f4578b32 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_7f56ea63061432843ab4dd16f4578b32(s, config);
}

}


