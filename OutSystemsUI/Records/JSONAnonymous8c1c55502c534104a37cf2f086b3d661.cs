using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// StepsRecord
public class JSONRC_0d776a4e191faf321030d5ce57aa4167 : AbstractRESTStructure<RC_0d776a4e191faf321030d5ce57aa4167> {
[JsonProperty("Steps")]
[JsonPropertyName("Steps")]
public ssOutSystemsUI.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord AttrSteps;

public JSONRC_0d776a4e191faf321030d5ce57aa4167() { }

public JSONRC_0d776a4e191faf321030d5ce57aa4167 (RC_0d776a4e191faf321030d5ce57aa4167 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSteps = ConvertToRestWithoutDefaults(s.ssENSteps, new EN_7441573ccf264d27ef548a39a846bd68EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord.FromStructureDelegate(config));
  } else {
AttrSteps = ssOutSystemsUI.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord.FromStructure(s.ssENSteps, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_0d776a4e191faf321030d5ce57aa4167, RC_0d776a4e191faf321030d5ce57aa4167> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_0d776a4e191faf321030d5ce57aa4167 s) => ToStructure(s, config);
}
public static RC_0d776a4e191faf321030d5ce57aa4167 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_0d776a4e191faf321030d5ce57aa4167 obj, IBehaviorsConfiguration config) { 
  RC_0d776a4e191faf321030d5ce57aa4167 s = new RC_0d776a4e191faf321030d5ce57aa4167();
  if(obj != null) {
  s.ssENSteps = ssOutSystemsUI.RestRecords.JSONEN_7441573ccf264d27ef548a39a846bd68EntityRecord.ToStructure(obj.AttrSteps, config);
  }
  return s;
}

public static Func<RC_0d776a4e191faf321030d5ce57aa4167, ssOutSystemsUI.RestRecords.JSONRC_0d776a4e191faf321030d5ce57aa4167> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0d776a4e191faf321030d5ce57aa4167 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_0d776a4e191faf321030d5ce57aa4167 FromStructure(RC_0d776a4e191faf321030d5ce57aa4167 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_0d776a4e191faf321030d5ce57aa4167(s, config);
}

}


