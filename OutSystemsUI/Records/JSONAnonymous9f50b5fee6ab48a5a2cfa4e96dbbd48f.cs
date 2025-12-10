using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FlipContent_InternalConfigRecord
public class JSONRC_b1f70cd6a745b5879d66249a8c483fef : AbstractRESTStructure<RC_b1f70cd6a745b5879d66249a8c483fef> {
[JsonProperty("FlipContent_InternalConfig")]
[JsonPropertyName("FlipContent_InternalConfig")]
public ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure AttrFlipContent_InternalConfig;

public JSONRC_b1f70cd6a745b5879d66249a8c483fef() { }

public JSONRC_b1f70cd6a745b5879d66249a8c483fef (RC_b1f70cd6a745b5879d66249a8c483fef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFlipContent_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTFlipContent_InternalConfig, new ST_e828cdbd51e0c1ef095bd323f6e2875aStructure(), ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure.FromStructureDelegate(config));
  } else {
AttrFlipContent_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure.FromStructure(s.ssSTFlipContent_InternalConfig, config);
  }
}

public static Func<ssOutSystemsUI.RestRecords.JSONRC_b1f70cd6a745b5879d66249a8c483fef, RC_b1f70cd6a745b5879d66249a8c483fef> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssOutSystemsUI.RestRecords.JSONRC_b1f70cd6a745b5879d66249a8c483fef s) => ToStructure(s, config);
}
public static RC_b1f70cd6a745b5879d66249a8c483fef ToStructure(ssOutSystemsUI.RestRecords.JSONRC_b1f70cd6a745b5879d66249a8c483fef obj, IBehaviorsConfiguration config) { 
  RC_b1f70cd6a745b5879d66249a8c483fef s = new RC_b1f70cd6a745b5879d66249a8c483fef();
  if(obj != null) {
  s.ssSTFlipContent_InternalConfig = ssOutSystemsUI.RestRecords.JSONST_e828cdbd51e0c1ef095bd323f6e2875aStructure.ToStructure(obj.AttrFlipContent_InternalConfig, config);
  }
  return s;
}

public static Func<RC_b1f70cd6a745b5879d66249a8c483fef, ssOutSystemsUI.RestRecords.JSONRC_b1f70cd6a745b5879d66249a8c483fef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b1f70cd6a745b5879d66249a8c483fef s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.JSONRC_b1f70cd6a745b5879d66249a8c483fef FromStructure(RC_b1f70cd6a745b5879d66249a8c483fef s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.JSONRC_b1f70cd6a745b5879d66249a8c483fef(s, config);
}

}


