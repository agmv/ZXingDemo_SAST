using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// VideoStateRecord
public class RESTRC_03619642a06de09478f0b8f506c364eb : AbstractRESTStructure<RC_03619642a06de09478f0b8f506c364eb> {
[JsonProperty("VideoState")]
public ssOutSystemsUI.RestRecords.RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord AttrVideoState;

public RESTRC_03619642a06de09478f0b8f506c364eb() { }

public RESTRC_03619642a06de09478f0b8f506c364eb (RC_03619642a06de09478f0b8f506c364eb s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrVideoState = ConvertToRestWithoutDefaults(s.ssENVideoState, new EN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord.FromStructureDelegate(config));
  } else {
AttrVideoState = ssOutSystemsUI.RestRecords.RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord.FromStructure(s.ssENVideoState, config);
  }
}

public static RC_03619642a06de09478f0b8f506c364eb ToStructure(ssOutSystemsUI.RestRecords.RESTRC_03619642a06de09478f0b8f506c364eb obj) { 
  RC_03619642a06de09478f0b8f506c364eb s = new RC_03619642a06de09478f0b8f506c364eb();
  if(obj != null) {
  s.ssENVideoState = ssOutSystemsUI.RestRecords.RESTEN_75c9c074bd528ecee8df4d2a3299b5a1EntityRecord.ToStructure(obj.AttrVideoState);
  }
  return s;
}

public static Func<RC_03619642a06de09478f0b8f506c364eb, ssOutSystemsUI.RestRecords.RESTRC_03619642a06de09478f0b8f506c364eb> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_03619642a06de09478f0b8f506c364eb s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_03619642a06de09478f0b8f506c364eb FromStructure(RC_03619642a06de09478f0b8f506c364eb s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_03619642a06de09478f0b8f506c364eb(s, config);
}

}


