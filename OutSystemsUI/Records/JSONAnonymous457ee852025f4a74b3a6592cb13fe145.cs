using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// ProgressTypeRecord
public class JSONRC_0832b315fa435e0ff97aca2a0ca6bd44 : AbstractRESTStructure<RC_0832b315fa435e0ff97aca2a0ca6bd44> {
[JsonProperty("ProgressType")]
[JsonPropertyName("ProgressType")]
public ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord AttrProgressType;

public JSONRC_0832b315fa435e0ff97aca2a0ca6bd44() { }

public JSONRC_0832b315fa435e0ff97aca2a0ca6bd44 (RC_0832b315fa435e0ff97aca2a0ca6bd44 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProgressType = ConvertToRestWithoutDefaults(s.ssENProgressType, new EN_e168de2e23691f28c2b57a8300aa4d06EntityRecord(), ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord.FromStructureDelegate(config));
  } else {
AttrProgressType = ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord.FromStructure(s.ssENProgressType, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_0832b315fa435e0ff97aca2a0ca6bd44, RC_0832b315fa435e0ff97aca2a0ca6bd44> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_0832b315fa435e0ff97aca2a0ca6bd44 s) => ToStructure(s, config);
}
public static RC_0832b315fa435e0ff97aca2a0ca6bd44 ToStructure(ssOutSystemsUI.RestRecords.JSONRC_0832b315fa435e0ff97aca2a0ca6bd44 obj, IBehaviorsConfiguration config) { 
  RC_0832b315fa435e0ff97aca2a0ca6bd44 s = new RC_0832b315fa435e0ff97aca2a0ca6bd44();
  if(obj != null) {
  s.ssENProgressType = ssOutSystemsUI.RestRecords.JSONEN_e168de2e23691f28c2b57a8300aa4d06EntityRecord.ToStructure(obj.AttrProgressType, config);
  }
  return s;
}

public static Func<RC_0832b315fa435e0ff97aca2a0ca6bd44, ssOutSystemsUI.RestRecords.JSONRC_0832b315fa435e0ff97aca2a0ca6bd44> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0832b315fa435e0ff97aca2a0ca6bd44 s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_0832b315fa435e0ff97aca2a0ca6bd44 FromStructure(RC_0832b315fa435e0ff97aca2a0ca6bd44 s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_0832b315fa435e0ff97aca2a0ca6bd44(s, config);
}

}


