using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssOutSystemsUI.RestRecords;

// FlipContent_InternalConfigRecord
public class RESTRC_b1f70cd6a745b5879d66249a8c483fef : AbstractRESTStructure<RC_b1f70cd6a745b5879d66249a8c483fef> {
[JsonProperty("FlipContent_InternalConfig")]
public ssOutSystemsUI.RestRecords.RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure AttrFlipContent_InternalConfig;

public RESTRC_b1f70cd6a745b5879d66249a8c483fef() { }

public RESTRC_b1f70cd6a745b5879d66249a8c483fef (RC_b1f70cd6a745b5879d66249a8c483fef s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFlipContent_InternalConfig = ConvertToRestWithoutDefaults(s.ssSTFlipContent_InternalConfig, new ST_e828cdbd51e0c1ef095bd323f6e2875aStructure(), ssOutSystemsUI.RestRecords.RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure.FromStructureDelegate(config));
  } else {
AttrFlipContent_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure.FromStructure(s.ssSTFlipContent_InternalConfig, config);
  }
}

public static RC_b1f70cd6a745b5879d66249a8c483fef ToStructure(ssOutSystemsUI.RestRecords.RESTRC_b1f70cd6a745b5879d66249a8c483fef obj) { 
  RC_b1f70cd6a745b5879d66249a8c483fef s = new RC_b1f70cd6a745b5879d66249a8c483fef();
  if(obj != null) {
  s.ssSTFlipContent_InternalConfig = ssOutSystemsUI.RestRecords.RESTST_e828cdbd51e0c1ef095bd323f6e2875aStructure.ToStructure(obj.AttrFlipContent_InternalConfig);
  }
  return s;
}

public static Func<RC_b1f70cd6a745b5879d66249a8c483fef, ssOutSystemsUI.RestRecords.RESTRC_b1f70cd6a745b5879d66249a8c483fef> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b1f70cd6a745b5879d66249a8c483fef s) => FromStructure(s, config);
}
public static ssOutSystemsUI.RestRecords.RESTRC_b1f70cd6a745b5879d66249a8c483fef FromStructure(RC_b1f70cd6a745b5879d66249a8c483fef s, IBehaviorsConfiguration config) { 
  return new ssOutSystemsUI.RestRecords.RESTRC_b1f70cd6a745b5879d66249a8c483fef(s, config);
}

}


