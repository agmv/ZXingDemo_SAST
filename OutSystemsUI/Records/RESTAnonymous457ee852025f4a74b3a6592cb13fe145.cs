using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressTypeRecord
public class RESTRC_0832b315fa435e0ff97aca2a0ca6bd44 : AbstractRESTStructure<RC_0832b315fa435e0ff97aca2a0ca6bd44> {
[JsonProperty("ProgressType")]
public ssOutSystemsUI.RestRecords.RESTEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord AttrProgressType;

public RESTRC_0832b315fa435e0ff97aca2a0ca6bd44() { }

public RESTRC_0832b315fa435e0ff97aca2a0ca6bd44 (RC_0832b315fa435e0ff97aca2a0ca6bd44 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressType = ConvertToRestWithoutDefaults(s.ssENProgressType, new EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord(), ssOutSystemsUI.RestRecords.RESTEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord.FromStructureDelegate(config));
  } else {
AttrProgressType = ssOutSystemsUI.RestRecords.RESTEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord.FromStructure(s.ssENProgressType, config);
  }
}

public static RC_0832b315fa435e0ff97aca2a0ca6bd44 ToStructure(ssOutSystemsUI.RestRecords.RESTRC_0832b315fa435e0ff97aca2a0ca6bd44 obj) { 
  RC_0832b315fa435e0ff97aca2a0ca6bd44 s = new RC_0832b315fa435e0ff97aca2a0ca6bd44();
  if(obj != null) {
  s.ssENProgressType = ssOutSystemsUI.RestRecords.RESTEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord.ToStructure(obj.AttrProgressType);
  }
  return s;
}

public static Func<RC_0832b315fa435e0ff97aca2a0ca6bd44, ssOutSystemsUI.RestRecords.RESTRC_0832b315fa435e0ff97aca2a0ca6bd44> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0832b315fa435e0ff97aca2a0ca6bd44 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_0832b315fa435e0ff97aca2a0ca6bd44 FromStructure(RC_0832b315fa435e0ff97aca2a0ca6bd44 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_0832b315fa435e0ff97aca2a0ca6bd44(s, config);
}

}


