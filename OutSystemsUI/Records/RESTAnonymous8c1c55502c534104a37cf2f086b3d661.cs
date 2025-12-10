using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// StepsRecord
public class RESTRC_0d776a4e191faf321030d5ce57aa4167 : AbstractRESTStructure<RC_0d776a4e191faf321030d5ce57aa4167> {
[JsonProperty("Steps")]
public ssOutSystemsUI.RestRecords.RESTEN_7441573ccf264d27ef548a39a846bd68EntityRecord AttrSteps;

public RESTRC_0d776a4e191faf321030d5ce57aa4167() { }

public RESTRC_0d776a4e191faf321030d5ce57aa4167 (RC_0d776a4e191faf321030d5ce57aa4167 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSteps = ConvertToRestWithoutDefaults(s.ssENSteps, new EN_7441573ccf264d27ef548a39a846bd68EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_7441573ccf264d27ef548a39a846bd68EntityRecord.FromStructureDelegate(config));
  } else {
AttrSteps = ssOutSystemsUI.RestRecords.RESTEN_7441573ccf264d27ef548a39a846bd68EntityRecord.FromStructure(s.ssENSteps, config);
  }
}

public static RC_0d776a4e191faf321030d5ce57aa4167 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_0d776a4e191faf321030d5ce57aa4167 obj) { 
  RC_0d776a4e191faf321030d5ce57aa4167 s = new RC_0d776a4e191faf321030d5ce57aa4167();
  if(obj != null) {
  s.ssENSteps = ssOutSystemsUI.RestRecords.RESTEN_7441573ccf264d27ef548a39a846bd68EntityRecord.ToStructure(obj.AttrSteps);
  }
  return s;
}

public static Func<RC_0d776a4e191faf321030d5ce57aa4167, ssOutSystemsUI.RestRecords.RESTRC_0d776a4e191faf321030d5ce57aa4167> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0d776a4e191faf321030d5ce57aa4167 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_0d776a4e191faf321030d5ce57aa4167 FromStructure(RC_0d776a4e191faf321030d5ce57aa4167 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_0d776a4e191faf321030d5ce57aa4167(s, config);
}

}


